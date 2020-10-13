using System.Threading.Tasks;
using System.Threading;

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
        /// Operation: Get User Business Hours
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
        /// Operation: Update User Business Hours
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