using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Leave
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
            return $"{parent.Path()}/leave";
        }

        /// <summary>
        /// Operation: Leave Team
        /// Http Post /restapi/v1.0/glip/teams/{chatId}/leave
        /// </summary>
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Leave.Index Leave()
        {
            return new Restapi.Glip.Teams.Leave.Index(this);
        }
    }
}