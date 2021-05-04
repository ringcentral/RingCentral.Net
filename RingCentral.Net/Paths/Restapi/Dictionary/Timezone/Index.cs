using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Timezone
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string timezoneId;

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
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/timezone
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetTimezoneListResponse> List(
            RingCentral.ListTimezonesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.GetTimezoneListResponse>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns the information on a certain timezone.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/timezone/{timezoneId}
        /// Rate Limit Group: Light
        /// </summary>
        public async Task<RingCentral.GetTimezoneInfoResponse> Get(
            RingCentral.ReadTimezoneParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (timezoneId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(timezoneId));
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