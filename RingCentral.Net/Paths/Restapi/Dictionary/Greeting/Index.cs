using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Dictionary.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Dictionary.Index parent;

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
        /// Operation: Get Standard Greeting List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/greeting
        /// Rate Limit Group: Medium
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DictionaryGreetingList> List(ListStandardGreetingsParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.DictionaryGreetingList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Standard Greeting
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/dictionary/greeting/{greetingId}
        /// Rate Limit Group: Medium
        /// App Permission: undefined
        /// User Permission: undefined
        /// </summary>
        public async Task<RingCentral.DictionaryGreetingInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
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