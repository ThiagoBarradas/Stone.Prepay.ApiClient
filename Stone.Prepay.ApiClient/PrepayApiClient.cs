using Stone.Prepay.ApiClient.Resources;
using Stone.Prepay.ApiClient.Resources.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.Prepay.ApiClient
{
    public class PrepayApiClient : IPrepayApiClient
    {
        #region Constructor
        
        /// <summary>
        /// Cliente para uso da API de antecipação de recebíveis da Stone
        /// </summary>
        /// <param name="apiUrl"></param>
        public PrepayApiClient(string apiUrl)
        {
            this.MerchantConfiguration = new MerchantConfiguration(apiUrl);
            this.TimelyReceivableAdvance = new TimelyReceivableAdvance(apiUrl);
            this.ManualReceivableAdvance = new ManualReceivableAdvance(apiUrl);
            this.AutomaticReceivableAdvance = new AutomaticReceivableAdvance(apiUrl);
        }

        #endregion 

        #region Resources

        public IMerchantConfiguration MerchantConfiguration { get; private set; }

        public ITimelyReceivableAdvance TimelyReceivableAdvance { get; private set; }

        public IManualReceivableAdvance ManualReceivableAdvance { get; private set; }

        public IAutomaticReceivableAdvance AutomaticReceivableAdvance { get; private set; }

        #endregion
    }
}
