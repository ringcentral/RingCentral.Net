using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration.Assistants
{
    public class Index
    {
        public MeetingsConfiguration.Index parent;
        public RestClient rc;

        public Index(MeetingsConfiguration.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/assistants";
        }

        /// <summary>
        ///     Returns assistants information.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<AssistantsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AssistantsResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration
{
    public partial class Index
    {
        public Assistants.Index Assistants()
        {
            return new Assistants.Index(this);
        }
    }
}