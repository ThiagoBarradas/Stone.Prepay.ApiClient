using RestSharp.Serializers;
using Stone.Prepay.ApiClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Response
{
    public class ReceivableAdvanceResume
    {  
        public int MerchantId { get; set; }
        
        public int ReceivableAdvanceResumeId { get; set; }
        
        public string AffiliationKey { get; set; }
        
        public string AffiliationCode { get; set; }
        
        public decimal TotalNetAmount { get; set; }
        
        public decimal TotalAdvancedNetAmount { get; set; }
        
        public decimal TotalWarrantyAmount { get; set; }
        
        public decimal TotalSettlementAmount { get; set; }
        
        public decimal AdvanceRate { get; set; }
        
        public decimal WarrantyRate { get; set; }
        
        public decimal TotalRevenueAmount { get; set; }
        
        public DateTime AdvanceDate { get; set; }
        
        public DateTime CreationDate { get; set; }
        
        public int BatchExecutionId { get; set; }
    }
}
