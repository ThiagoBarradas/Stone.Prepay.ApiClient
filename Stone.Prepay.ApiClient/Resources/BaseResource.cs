using Newtonsoft.Json;
using RestSharp;
using Stone.Prepay.ApiClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources
{
    public abstract class BaseResource
    {
        #region Constructor / Atributtes

        public RestClient RestClient { get; private set; }

        public BaseResource(string apiUrl)
        {
            this.RestClient = new RestClient(apiUrl);
        }

        #endregion 

        #region Helpers

        protected BaseResponse<T> MountResponse<T>(IRestResponse<T> restResponse)
        {
            if (restResponse.ErrorException != null) throw restResponse.ErrorException;

            BaseResponse<T> response = new BaseResponse<T>();
            response.StatusCode = restResponse.StatusCode;
            response.RawResponse = restResponse.Content;
            response.Data = restResponse.Data;
            response.IsSuccess = this.GetSuccessFromStatusCode(restResponse.StatusCode); 
            response.ErrorMessage = this.GetErrorMessageFromBadRequest(restResponse);

            return response;
        }

        protected string GetErrorMessageFromBadRequest(IRestResponse restResponse)
        {
            if (restResponse.StatusCode != HttpStatusCode.BadRequest) return null;
            
            var error = JsonConvert.DeserializeObject<dynamic>(restResponse.Content);
            return error.Message;
        }

        protected bool GetSuccessFromStatusCode(HttpStatusCode statusCode)
        {
            List<HttpStatusCode> successStatusCode = new List<HttpStatusCode>();
            successStatusCode.Add(HttpStatusCode.OK);
            successStatusCode.Add(HttpStatusCode.Created);
            successStatusCode.Add(HttpStatusCode.Accepted);
            successStatusCode.Add(HttpStatusCode.NoContent);

            return successStatusCode.Contains(statusCode);
        }

        #endregion
    }
}
