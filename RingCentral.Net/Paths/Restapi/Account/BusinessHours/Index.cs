using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.BusinessHours
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-hours";
        }

        /// <summary>
        /// Returns the company business hours schedule. Business hours (and After hours - all the remaining time) schedules are commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/business-hours
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyBusinessHours> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyBusinessHours>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the company business hours schedule.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/business-hours
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyBusinessHours> Put(
            RingCentral.CompanyBusinessHoursUpdateRequest companyBusinessHoursUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.CompanyBusinessHours>(this.Path(), companyBusinessHoursUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.BusinessHours.Index BusinessHours()
        {
            return new Restapi.Account.BusinessHours.Index(this);
        }
    }
}