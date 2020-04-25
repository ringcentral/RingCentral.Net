using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public string greetingId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string greetingId = null)
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
        /// Operation: Create Custom User Greeting
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Post(
            CreateCustomUserGreetingRequest createCustomUserGreetingRequest,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCustomUserGreetingRequest);
            return await rc.Post<RingCentral.CustomUserGreetingInfo>(this.Path(false), multipartFormDataContent, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Get Custom Greeting
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}
        /// </summary>
        public async Task<RingCentral.CustomUserGreetingInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.greetingId == null)
            {
                throw new System.ArgumentNullException("greetingId");
            }

            return await rc.Get<RingCentral.CustomUserGreetingInfo>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Greeting.Index Greeting(string greetingId = null)
        {
            return new Restapi.Account.Extension.Greeting.Index(this, greetingId);
        }
    }
}