using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration.Assistants
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.MeetingsConfiguration.Index parent;

        public Index(Restapi.Account.Extension.MeetingsConfiguration.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/assistants";
        }

        /// <summary>
        /// Operation: Get Assistants
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants
        /// </summary>
        public async Task<RingCentral.AssistantsResource> Get()
        {
            return await rc.Get<RingCentral.AssistantsResource>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration
{
    public partial class Index
    {
        public Restapi.Account.Extension.MeetingsConfiguration.Assistants.Index Assistants()
        {
            return new Restapi.Account.Extension.MeetingsConfiguration.Assistants.Index(this);
        }
    }
}