using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Join
{
    public class Index
    {
        public Teams.Index parent;
        public RestClient rc;

        public Index(Teams.Index parent)
        {
            this.parent = parent;
            rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/join";
        }

        /// <summary>
        ///     Adds the current user to the specified team. A team is a chat between 2 and more participants assigned with
        ///     specific name.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/glip/teams/{chatId}/join
        ///     Rate Limit Group: Medium
        ///     App Permission: Glip
        ///     User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Join.Index Join()
        {
            return new Join.Index(this);
        }
    }
}