using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Timezone
{
    public partial class Index
    {
        public RestClient rc;
        public string timezoneId;
        public Restapi.Dictionary.Index parent;

        public Index(Restapi.Dictionary.Index parent, string timezoneId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.timezoneId = timezoneId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && timezoneId != null)
            {
                return $"{parent.Path()}/timezone/{timezoneId}";
            }

            return $"{parent.Path()}/timezone";
        }

        public async Task<RingCentral.GetTimezoneListResponse> List()
        {
            return await rc.Get<RingCentral.GetTimezoneListResponse>(this.Path(false));
        }

        public async Task<RingCentral.GetTimezoneInfoResponse> Get()
        {
            if (this.timezoneId == null)
            {
                throw new System.ArgumentNullException("timezoneId");
            }

            return await rc.Get<RingCentral.GetTimezoneInfoResponse>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Timezone.Index Timezone(string timezoneId = null)
        {
            return new Restapi.Dictionary.Timezone.Index(this, timezoneId);
        }
    }
}