using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.BusinessHours
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-hours";
        }

        /// <summary>
        /// Returns the user business hours schedule. Business hours (and After hours - all the remaining time) schedules are commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly. **Please note:** If the user business hours are set to 'Custom hours' then a particular schedule is returned; however if set to '24 hours/7 days a week' the schedule will be empty.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadExtensions
        /// </summary>
        public async Task<RingCentral.GetUserBusinessHoursResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetUserBusinessHoursResponse>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates the user business hours schedule.
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.UserBusinessHoursUpdateResponse> Put(
            RingCentral.UserBusinessHoursUpdateRequest userBusinessHoursUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.UserBusinessHoursUpdateResponse>(this.Path(),
                userBusinessHoursUpdateRequest, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.BusinessHours.Index BusinessHours()
        {
            return new Restapi.Account.Extension.BusinessHours.Index(this);
        }
    }
}