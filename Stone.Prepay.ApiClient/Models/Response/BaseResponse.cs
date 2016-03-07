using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Response
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string RawResponse { get; set; }

        public string ErrorMessage { get; set; }
    }
}
