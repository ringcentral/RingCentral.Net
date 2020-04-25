using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public RestClient rc;
        public string chatId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string chatId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.chatId = chatId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && chatId != null)
            {
                return $"{parent.Path()}/teams/{chatId}";
            }

            return $"{parent.Path()}/teams";
        }

        /// <summary>
        /// Operation: Get Teams
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/teams
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamsList> List(ListGlipTeamsParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.GlipTeamsList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Team
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Post(RingCentral.GlipPostTeamBody glipPostTeamBody,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipTeamInfo>(this.Path(false), glipPostTeamBody, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Team
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Light
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipTeamInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Team
        /// HTTP Method: PATCH
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<RingCentral.GlipTeamInfo> Patch(RingCentral.GlipPatchTeamBody glipPatchTeamBody,
            CancellationToken? cancellationToken = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Patch<RingCentral.GlipTeamInfo>(this.Path(), glipPatchTeamBody, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Team
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}
        /// Rate Limit Group: Medium
        /// App Permission Required: Glip
        /// User Permission Required: Glip
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Index Teams(string chatId = null)
        {
            return new Restapi.Glip.Teams.Index(this, chatId);
        }
    }
}