using System.Threading.Tasks;
using System.Threading;

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
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants
        /// Rate Limit Group: Light
        /// App Permission Required: Meetings
        /// User Permission Required: Meetings
        /// </summary>
        public async Task<RingCentral.AssistantsResource> Get(CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.AssistantsResource>(this.Path(), null, cancellationToken);
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