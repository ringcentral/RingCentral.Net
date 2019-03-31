using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Greeting
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/greeting";
        }

        /// <summary>
        /// Operation: Create Custom Company Greeting
        /// Http Post /restapi/v1.0/account/{accountId}/greeting
        /// </summary>
        public async Task<RingCentral.CustomCompanyGreetingInfo> Post(
            CreateCompanyGreetingRequest createCompanyGreetingRequest)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createCompanyGreetingRequest);
            return await rc.Post<RingCentral.CustomCompanyGreetingInfo>(this.Path(), multipartFormDataContent);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Greeting.Index Greeting()
        {
            return new Restapi.Account.Greeting.Index(this);
        }
    }
}