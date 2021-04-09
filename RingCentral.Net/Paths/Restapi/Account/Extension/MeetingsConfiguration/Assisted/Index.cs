using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration.Assisted
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
            return $"{parent.Path()}/assisted";
        }

        /// <summary>
        ///     Returns assisted users information.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted
        ///     Rate Limit Group: Light
        ///     App Permission: Meetings
        ///     User Permission: Meetings
        /// </summary>
        public async Task<AssistedUsersResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<AssistedUsersResource>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MeetingsConfiguration
{
    public partial class Index
    {
        public Assisted.Index Assisted()
        {
            return new Assisted.Index(this);
        }
    }
}