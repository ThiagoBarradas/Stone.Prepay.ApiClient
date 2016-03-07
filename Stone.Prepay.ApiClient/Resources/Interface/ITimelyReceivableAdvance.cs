using Stone.Prepay.ApiClient.Models.Request;
using Stone.Prepay.ApiClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources.Interface
{
    public interface ITimelyReceivableAdvance
    {
        /// <summary>
        /// Obtem informações de antecipação da loja
        /// </summary>
        /// <param name="affiliationKey">Chave da afiliação</param>
        /// <returns></returns>
        BaseResponse<MerchantReceivableAdvanceInformation> GetMerchantInfo(string affiliationKey);

        /// <summary>
        /// Lista as propostas de antecipação de recebíveis ativas
        /// </summary>
        /// <param name="timelyReceivableAdvance">Proposta de antecidação de recebíveis</param>
        /// <returns></returns>
        BaseResponse<List<ReceivableAdvanceResume>> List(CreateTimelyReceivableAdvance timelyReceivableAdvance);

        /// <summary>
        /// Cria uma proposta de antecipação de recebíveis
        /// </summary>
        /// <param name="timelyReceivableAdvance">Proposta de antecidação de recebíveis</param>
        /// <returns></returns>
        BaseResponse<ReceivableAdvanceResume> Create(CreateTimelyReceivableAdvance timelyReceivableAdvance);

        /// <summary>
        /// Simula uma proposta de antecipação de recebíveis
        /// </summary>
        /// <param name="timelyReceivableAdvance">Proposta de antecidação de recebíveis</param>
        /// <returns></returns>
        BaseResponse<ReceivableAdvanceResume> Simulate(CreateTimelyReceivableAdvance timelyReceivableAdvance);

        /// <summary>
        /// Remove uma proposta de antecipação de recebíveis
        /// </summary>
        /// <param name="proposalId">ID da proposta</param>
        /// <returns></returns>
        BaseResponse<object> Remove(string proposalId);
    }
}
