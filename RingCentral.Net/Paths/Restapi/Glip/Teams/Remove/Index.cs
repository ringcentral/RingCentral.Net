using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Teams.Remove
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/remove";
        }

        /// <summary>
        /// Operation: Remove Team Members
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}/remove
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<string> Post(RingCentral.GlipPostMembersIdsListBody glipPostMembersIdsListBody,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<string>(this.Path(), glipPostMembersIdsListBody, null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Remove.Index Remove()
        {
            return new Restapi.Glip.Teams.Remove.Index(this);
        }
    }
}