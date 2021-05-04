using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Dictionary.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Dictionary.Index parent;
        public string greetingId;

        public Index(Restapi.Dictionary.Index parent, string greetingId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.greetingId = greetingId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && greetingId != null)
            {
                return $"{parent.Path()}/greeting/{greetingId}";
            }

            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        /// Returns the list of predefined standard greetings. Custom greetings recorded by user are not returned in response to this request. See Get Extension Custom Greetings.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/greeting
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.DictionaryGreetingList> List(
            RingCentral.ListStandardGreetingsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.DictionaryGreetingList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Returns a standard greeting by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/dictionary/greeting/{greetingId}
        /// Rate Limit Group: Medium
        /// </summary>
        public async Task<RingCentral.DictionaryGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (greetingId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(greetingId));
            }

            return await rc.Get<RingCentral.DictionaryGreetingInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Dictionary
{
    public partial class Index
    {
        public Restapi.Dictionary.Greeting.Index Greeting(string greetingId = null)
        {
            return new Restapi.Dictionary.Greeting.Index(this, greetingId);
        }
    }
}