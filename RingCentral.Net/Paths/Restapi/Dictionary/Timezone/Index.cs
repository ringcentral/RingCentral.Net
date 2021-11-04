using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Timezone
{
    public class Index
    {
        public Dictionary.Index parent;
        public RestClient rc;
        public string timezoneId;

        public Index(Dictionary.Index parent, string timezoneId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.timezoneId = timezoneId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && timezoneId != null) return $"{parent.Path()}/timezone/{timezoneId}";

            return $"{parent.Path()}/timezone";
        }

        /// <summary>
        ///     Returns all available timezones.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/timezone
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<GetTimezoneListResponse> List(
            ListTimezonesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<GetTimezoneListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the information on a certain timezone.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/timezone/{timezoneId}
        ///     Rate Limit Group: Light
        /// </summary>
        public async Task<GetTimezoneInfoResponse> Get(
            ReadTimezoneParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            if (timezoneId == null) throw new ArgumentException("Parameter cannot be null", nameof(timezoneId));

            return await rc.Get<GetTimezoneInfoResponse>(Path(), queryParams, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Timezone.Index Timezone(string timezoneId = null)
        {
            return new Timezone.Index(this, timezoneId);
        }
    }
}