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

        /// <summary>
        /// Returns all available timezones.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/timezone
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetTimezoneListResponse> List(ListTimezonesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetTimezoneListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the information on a certain timezone.
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/timezone/{timezoneId}
        /// Rate Limit Group: Light
        /// App Permission: 
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.GetTimezoneInfoResponse> Get(ReadTimezoneParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.timezoneId == null)
            {
                throw new System.ArgumentNullException("timezoneId");
            }

            return await rc.Get<RingCentral.GetTimezoneInfoResponse>(this.Path(), queryParams, restRequestConfig);
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