using Stone.Prepay.ApiClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Response
{
    public class MerchantReceivableAdvanceInformation
    {
        public decimal TotalFutureReceivablesAmount { get; set; }

        public decimal TotalNotMaturedAdvancedNetAmount { get; set; }

        public decimal TotalAdvancedNetAmount { get; set; }

        public decimal TotalAdvanceableAmount { get; set; }

        public decimal WarrantyRate { get; set; }

        public decimal ChargebackRate { get; set; }

        public decimal MonthlyBillingAmount { get; set; }

        public decimal NegativeBalance { get; set; }
    }
}
