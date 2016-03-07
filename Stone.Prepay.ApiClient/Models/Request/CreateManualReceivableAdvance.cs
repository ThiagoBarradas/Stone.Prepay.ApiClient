using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Request
{
    public class CreateManualReceivableAdvance
    {
        public string AffiliationKey { get; set; }

        public string AffiliationCode { get; set; }

        public decimal AdvanceRate { get; set; }

        public DateTime AdvanceDate { get; set; }

        [SerializeAs(Name = "TransactionIdentifierCollection")]
        public List<TransactionIdentifier> TransactionIdentifiers { get; set; }
    }
}
