using Stone.Prepay.ApiClient.Resources.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient
{
    public interface IPrepayApiClient
    {
        /// <summary>
        /// Configuração de Loja
        /// </summary>
        IMerchantConfiguration MerchantConfiguration { get; }

        /// <summary>
        /// Proposta de Antecipação de Recebíveis
        /// </summary>
        ITimelyReceivableAdvance TimelyReceivableAdvance { get; }

        /// <summary>
        /// Antecipação Manual de Recebíveis
        /// </summary>
        IManualReceivableAdvance ManualReceivableAdvance { get; }

        /// <summary>
        /// Antecipação Automática de Recebíveis
        /// </summary>
        IAutomaticReceivableAdvance AutomaticReceivableAdvance { get; }
    }
}
