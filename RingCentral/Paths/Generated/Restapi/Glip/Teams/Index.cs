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

        public async Task<RingCentral.GlipTeamsList> List()
        {
            return await rc.Get<RingCentral.GlipTeamsList>(this.Path(false));
        }

        public async Task<RingCentral.GlipTeamInfo> Post(RingCentral.GlipPostTeamBody glipPostTeamBody)
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

        public async Task<string> Delete()
        {
            if (this.chatId == null)
            {
                throw new System.ArgumentNullException("chatId");
            }

            return await rc.Delete<string>(this.Path());
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