using Stone.Prepay.ApiClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Response
{
    public class MerchantConfigurationData
    {
        public string AffiliationKey { get; set; }
        
        public string AffiliationCode { get; set; }
        
        public string AdvanceRateExpression { get; set; }
        
        public decimal AdvanceRate { get; set; }
        
        public int MinAdvanceDaysNumber { get; set; }

        public decimal WarrantyRate { get; set; }
  
        public TransactionPickerType TransactionPickerType { get; set; }
  
        public bool HasAutomaticReceivableAdvance { get; set; }
        
        public bool IsBlocked { get; set; }
    }
}
