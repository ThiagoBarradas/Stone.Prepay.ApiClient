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
    public class AutomaticReceivableAdvance : BaseResource, IAutomaticReceivableAdvance
    {
        #region Constructor

        public AutomaticReceivableAdvance(string apiUrl) : base(apiUrl) { }

        #endregion

        #region Create

        public BaseResponse<ReceivableAdvanceResume> Create(CreateAutomaticReceivableAdvance automaticReceivableAdvance)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/automatic/{affiliationKey}", Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("affiliationKey", automaticReceivableAdvance.AffiliationKey);
            restRequest.AddJsonBody(automaticReceivableAdvance);

            // Execute
            IRestResponse<ReceivableAdvanceResume> restResponse = this.RestClient.Execute<ReceivableAdvanceResume>(restRequest);

            // Response
            var response = this.MountResponse<ReceivableAdvanceResume>(restResponse);

            return response;
        }

        #endregion
    }
}
