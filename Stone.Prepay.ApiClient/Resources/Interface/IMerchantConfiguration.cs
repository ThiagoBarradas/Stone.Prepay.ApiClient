using Stone.Prepay.ApiClient.Models;
using Stone.Prepay.ApiClient.Models.Request;
using Stone.Prepay.ApiClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient.Resources.Interface
{
    public interface IMerchantConfiguration
    {
        /// <summary>
        /// Obtem a configuração de uma loja
        /// </summary>
        /// <param name="affiliationKey">Chave da afiliação</param>
        /// <returns></returns>
        BaseResponse<MerchantConfigurationData> Get(string affiliationKey);

        /// <summary>
        /// Cria configuração para uma loja
        /// </summary>
        /// <param name="merchantConfiguration">Dados de configuração para criação</param>
        /// <returns></returns>
        BaseResponse<object> Create(CreateMerchantConfiguration merchantConfiguration);

        /// <summary>
        /// Atualiza a configuração de uma loja
        /// </summary>
        /// <param name="merchantConfiguration">Dados de configuração para atualização</param>
        /// <returns></returns>
        BaseResponse<object> Update(UpdateMerchantConfiguration merchantConfiguration);

        /// <summary>
        /// Remove a configuração de uma loja
        /// </summary>
        /// <param name="affiliationKey">Chave da afiliação</param>
        /// <returns></returns>
        BaseResponse<object> Remove(string affiliationKey);
    }
}
