using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.BusinessHours
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;

        public Index(Extension.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/business-hours";
        }

        /// <summary>
        ///     Returns the user business hours schedule. Business hours (and After hours - all the remaining time) schedules are
        ///     commonly used for setting call handling rules - `business-hours-rule` and `after-hours-rule` correspondingly.
        ///     **Please note:** If the user business hours are set to 'Custom hours' then a particular schedule is returned;
        ///     however if set to '24 hours/7 days a week' the schedule will be empty.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/business-hours
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadExtensions
        /// </summary>
        public async Task<GetUserBusinessHoursResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetUserBusinessHoursResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the user business hours schedule.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/business-hours
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<UserBusinessHoursUpdateResponse> Put(
            UserBusinessHoursUpdateRequest userBusinessHoursUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<UserBusinessHoursUpdateResponse>(Path(), userBusinessHoursUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public BusinessHours.Index BusinessHours()
        {
            return new BusinessHours.Index(this);
        }
    }
}