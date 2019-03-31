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
        /// Operation: Get User Business Hours
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours
        /// </summary>
        public async Task<RingCentral.GetUserBusinessHoursResponse> Get()
        {
            return await rc.Get<RingCentral.GetUserBusinessHoursResponse>(this.Path());
        }

        /// <summary>
        /// Operation: Update User Business Hours
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours
        /// </summary>
        public async Task<RingCentral.UserBusinessHoursUpdateResponse> Put(
            RingCentral.UserBusinessHoursUpdateRequest userBusinessHoursUpdateRequest)
        {
            return await rc.Put<RingCentral.UserBusinessHoursUpdateResponse>(this.Path(),
                userBusinessHoursUpdateRequest);
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