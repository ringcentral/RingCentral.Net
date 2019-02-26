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

        // Operation: loadUserBusinessHours
        public async Task<RingCentral.GetUserBusinessHoursResponse> Get()
        {
            return await rc.Get<RingCentral.GetUserBusinessHoursResponse>(this.Path());
        }

        // Operation: updateUserBusinessHours
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