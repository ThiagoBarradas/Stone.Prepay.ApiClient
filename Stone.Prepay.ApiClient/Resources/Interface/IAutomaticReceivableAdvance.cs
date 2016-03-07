using Stone.Prepay.ApiClient.Models.Request;
using Stone.Prepay.ApiClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources.Interface
{
    public interface IAutomaticReceivableAdvance
    {
        /// <summary>
        /// Cria uma antecipação de recebíveis automática
        /// </summary>
        /// <param name="automaticReceivableAdvance">Dados da antecidação de recebíveis automática</param>
        /// <returns></returns>
        BaseResponse<ReceivableAdvanceResume> Create(CreateAutomaticReceivableAdvance automaticReceivableAdvance);
    }
}
