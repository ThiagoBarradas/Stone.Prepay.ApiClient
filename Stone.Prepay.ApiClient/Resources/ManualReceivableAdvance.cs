using Newtonsoft.Json;
using RestSharp;
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
    public class ManualReceivableAdvance : BaseResource, IManualReceivableAdvance
    {
        #region Constructor

        public ManualReceivableAdvance(string apiUrl) : base(apiUrl) { }

        #endregion

        #region Create

        public BaseResponse<ReceivableAdvanceResume> Create(CreateManualReceivableAdvance manualReceivableAdvance)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/manualAdvance/{affiliationKey}", Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("affiliationKey", manualReceivableAdvance.AffiliationKey);
            restRequest.AddJsonBody(manualReceivableAdvance);

            // Execute
            IRestResponse<ReceivableAdvanceResume> restResponse = this.RestClient.Execute<ReceivableAdvanceResume>(restRequest);

            // Response
            var response = this.MountResponse<ReceivableAdvanceResume>(restResponse);

            return response;
        }

        #endregion
    }
}
