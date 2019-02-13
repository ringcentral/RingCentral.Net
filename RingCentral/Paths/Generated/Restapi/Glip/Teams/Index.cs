using System.Threading.Tasks;

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

        public async Task<RingCentral.GlipTeamsList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GlipTeamsList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipTeamsList> List(object queryParams)
        {
            return await rc.Get<RingCentral.GlipTeamsList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GlipTeamInfo> Post(RingCentral.GlipPostTeamBody glipPostTeamBody)
        {
            return await rc.Post<RingCentral.GlipTeamInfo>(this.Path(false), glipPostTeamBody);
        }

        public async Task<RingCentral.GlipTeamInfo> Post(object glipPostTeamBody)
        {
            return await rc.Post<RingCentral.GlipTeamInfo>(this.Path(false), glipPostTeamBody);
        }

        public async Task<RingCentral.GlipTeamInfo> Get()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Get<RingCentral.GlipTeamInfo>(this.Path());
        }

        public async Task<RingCentral.GlipTeamInfo> Patch(RingCentral.GlipPatchTeamBody glipPatchTeamBody)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Patch<RingCentral.GlipTeamInfo>(this.Path(), glipPatchTeamBody);
        }

        public async Task<RingCentral.GlipTeamInfo> Patch(object glipPatchTeamBody)
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Patch<RingCentral.GlipTeamInfo>(this.Path(), glipPatchTeamBody);
        }

        public async Task<string> Delete()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }

    public class ListQueryParams
    {
        // Number of teams to be fetched by one request. The maximum value is 250, by default - 30
        public long? recordCount;

        // Pagination token.
        public string pageToken;
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