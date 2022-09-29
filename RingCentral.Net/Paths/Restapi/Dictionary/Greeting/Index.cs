using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Dictionary.Greeting
{
    public class Index
    {
        public string greetingId;
        public Dictionary.Index parent;
        public RestClient rc;

        public Index(Dictionary.Index parent, string greetingId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null) return $"{parent.Path()}/greeting/{greetingId}";
            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        ///     Returns the list of predefined standard greetings. Custom greetings
        ///     recorded by user are not returned in response to this request. See Get Extension
        ///     Custom Greetings.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/greeting
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<DictionaryGreetingList> List(ListStandardGreetingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<DictionaryGreetingList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns a standard greeting by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/dictionary/greeting/{greetingId}
        ///     Rate Limit Group: Medium
        /// </summary>
        public async Task<DictionaryGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (greetingId == null) throw new ArgumentException("Parameter cannot be null", nameof(greetingId));
            return await rc.Get<DictionaryGreetingInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Greeting.Index Greeting(string greetingId = null)
        {
            return new Greeting.Index(this, greetingId);
        }
    }
}