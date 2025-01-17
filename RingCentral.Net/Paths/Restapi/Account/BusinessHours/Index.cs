using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.BusinessHours
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/business-hours";
        }

        /// <summary>
        ///     Returns the company business hours schedule. Business hours (and After hours - all the remaining time) schedules
        ///     are commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/business-hours
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<CompanyBusinessHours> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CompanyBusinessHours>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the company business hours schedule.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/business-hours
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<CompanyBusinessHours> Put(
            CompanyBusinessHoursUpdateRequest companyBusinessHoursUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CompanyBusinessHours>(Path(), companyBusinessHoursUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public BusinessHours.Index BusinessHours()
        {
            return new BusinessHours.Index(this);
        }
    }
}