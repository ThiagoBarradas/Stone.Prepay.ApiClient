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
    public class TimelyReceivableAdvance : BaseResource, ITimelyReceivableAdvance
    {
        #region Constructor

        public TimelyReceivableAdvance(string apiUrl) : base(apiUrl) { }

        #endregion

        #region Get Merchant Info

        public BaseResponse<MerchantReceivableAdvanceInformation> GetMerchantInfo(string affiliationKey)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/{affiliationKey}/information", Method.GET);
            restRequest.AddUrlSegment("affiliationKey", affiliationKey);
            restRequest.RequestFormat = DataFormat.Json;

            // Execute
            IRestResponse<MerchantReceivableAdvanceInformation> restResponse = this.RestClient.Execute<MerchantReceivableAdvanceInformation>(restRequest);

            // Response
            var response = this.MountResponse<MerchantReceivableAdvanceInformation>(restResponse);

            return response;
        }

        #endregion

        #region List

        public BaseResponse<List<ReceivableAdvanceResume>> List(CreateTimelyReceivableAdvance timelyReceivableAdvance)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/proposals/active", Method.GET);
            restRequest.RequestFormat = DataFormat.Json;

            // Execute
            IRestResponse<List<ReceivableAdvanceResume>> restResponse = this.RestClient.Execute<List<ReceivableAdvanceResume>>(restRequest);

            // Response
            var response = this.MountResponse<List<ReceivableAdvanceResume>>(restResponse);

            return response;
        }

        #endregion

        #region Get

        public BaseResponse<ReceivableAdvanceResume> Get(string proposalId)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/proposals/{proposalId}", Method.GET);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("proposalId", proposalId);

            // Execute
            IRestResponse<ReceivableAdvanceResume> restResponse = this.RestClient.Execute<ReceivableAdvanceResume>(restRequest);

            // Response
            var response = this.MountResponse<ReceivableAdvanceResume>(restResponse);

            return response;
        }

        #endregion

        #region Create

        public BaseResponse<ReceivableAdvanceResume> Create(CreateTimelyReceivableAdvance timelyReceivableAdvance)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/proposals", Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(timelyReceivableAdvance);

            // Execute
            IRestResponse<ReceivableAdvanceResume> restResponse = this.RestClient.Execute<ReceivableAdvanceResume>(restRequest);

            // Response
            var response = this.MountResponse<ReceivableAdvanceResume>(restResponse);

            return response;
        }

        #endregion

        #region Simulate

        public BaseResponse<ReceivableAdvanceResume> Simulate(CreateTimelyReceivableAdvance timelyReceivableAdvance)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/simulations", Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(timelyReceivableAdvance);

            // Execute
            IRestResponse<ReceivableAdvanceResume> restResponse = this.RestClient.Execute<ReceivableAdvanceResume>(restRequest);

            // Response
            var response = this.MountResponse<ReceivableAdvanceResume>(restResponse);

            return response;
        }

        #endregion

        #region Remove

        public BaseResponse<object> Remove(string proposalId)
        {
            // Request
            RestRequest restRequest = new RestRequest("/v1/timely/proposals/{proposalId}", Method.DELETE);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddUrlSegment("proposalId", proposalId);

            // Execute
            IRestResponse<object> restResponse = this.RestClient.Execute<object>(restRequest);

            // Response
            var response = this.MountResponse<object>(restResponse);

            return response;
        }

        #endregion
    }
}
