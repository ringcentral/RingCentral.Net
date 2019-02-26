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

        // Operation: listTimezones
        public async Task<RingCentral.GetTimezoneListResponse> List(ListTimezonesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.GetTimezoneListResponse>(this.Path(false), queryParams);
        }

        // Operation: loadTimezone
        public async Task<RingCentral.GetTimezoneInfoResponse> Get(LoadTimezoneParameters queryParams = null)
        {
            if (this.timezoneId == null)
            {
                throw new System.ArgumentNullException("timezoneId");
            }

            return await rc.Get<RingCentral.GetTimezoneInfoResponse>(this.Path(), queryParams);
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