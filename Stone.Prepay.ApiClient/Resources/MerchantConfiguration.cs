using RestSharp;
using Stone.Prepay.ApiClient.Models;
using Stone.Prepay.ApiClient.Models.Request;
using Stone.Prepay.ApiClient.Models.Response;
using Stone.Prepay.ApiClient.Resources.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources
{
    public class MerchantConfiguration : BaseResource, IMerchantConfiguration
    {
        #region Constructor

        public MerchantConfiguration(string apiUrl) : base(apiUrl) { }

        #endregion

        #region Get

        public BaseResponse<MerchantConfigurationData> Get(string affiliationKey)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/merchant/{affiliationKey}/config", Method.GET);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("affiliationKey", affiliationKey);
            
            // Execute
            IRestResponse<MerchantConfigurationData> restResponse = this.RestClient.Execute<MerchantConfigurationData>(restRequest);

            // Response
            var response = this.MountResponse<MerchantConfigurationData>(restResponse);

            return response;
        }

        #endregion

        #region Create

        public BaseResponse<object> Create(string affiliationKey, CreateMerchantConfiguration merchantConfiguration)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/merchant/{affiliationKey}/config", Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(merchantConfiguration);
            restRequest.AddUrlSegment("affiliationKey", affiliationKey);

            // Execute
            IRestResponse<object> restResponse = this.RestClient.Execute<object>(restRequest);

            // Response
            var response = this.MountResponse<object>(restResponse);

            return response;
        }

        #endregion

        #region Update

        public BaseResponse<object> Update(string affiliationKey, UpdateMerchantConfiguration merchantConfiguration)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/merchant/{affiliationKey}/config", Method.PUT);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(merchantConfiguration);
            restRequest.AddUrlSegment("affiliationKey", affiliationKey);

            // Execute
            IRestResponse<object> restResponse = this.RestClient.Execute<object>(restRequest);

            // Response
            var response = this.MountResponse<object>(restResponse);

            return response;
        }

        #endregion

        #region Remove

        public BaseResponse<object> Remove(string affiliationKey)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/merchant/{affiliationKey}/config", Method.DELETE);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("affiliationKey", affiliationKey);

            // Execute
            IRestResponse<object> restResponse = this.RestClient.Execute<object>(restRequest);

            // Response
            var response = this.MountResponse<object>(restResponse);

            return response;
        }

        #endregion
    }
}
