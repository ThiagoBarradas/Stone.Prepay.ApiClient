using Stone.Prepay.ApiClient.Models.Request;
using Stone.Prepay.ApiClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources.Interface
{
    public interface IManualReceivableAdvance
    {
        /// <summary>
        /// Cria uma antecipação de recebíveis manualmente para a loja
        /// </summary>
        /// <param name="manualReceivableAdvance">Dados da antecidação de recebíveis manual</param>
        /// <returns></returns>
        BaseResponse<ReceivableAdvanceResume> Create(CreateManualReceivableAdvance manualReceivableAdvance);
    }
}
