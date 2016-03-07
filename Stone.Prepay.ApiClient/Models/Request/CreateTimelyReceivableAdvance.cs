using RestSharp.Serializers;
using Stone.Prepay.ApiClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Request
{
    public class CreateTimelyReceivableAdvance
    {  
        public string AffiliationKey { get; set; }
  
        public string AffiliationCode { get; set; }
  
        public decimal AdvanceRate { get; set; }
  
        public DateTime AdvanceDate { get; set; }
  
        public TransactionPickerType TransactionPickerType { get; set; }
        
        public decimal TotalAmountToBeAdvanced { get; set; }
        
        public int MinAdvanceDaysNumber { get; set; }

        [SerializeAs(Name = "BrandIdToBeAdvancedCollection")]
        public List<Brand> BrandToBeAdvanced { get; set; }
    
    }
}
