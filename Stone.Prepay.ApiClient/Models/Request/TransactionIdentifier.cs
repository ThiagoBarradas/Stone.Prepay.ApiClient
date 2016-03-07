using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Models.Request
{
    public class TransactionIdentifier
    {
        public string AcquirerTransactionKey { get; set; }

        public int InstallmentNumber { get; set; }
    }
}
