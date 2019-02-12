using System.Threading.Tasks;

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

        public async Task<string> Post(RingCentral.GlipPostMembersIdsListBody glipPostMembersIdsListBody)
        {
            return await rc.Post<string>(this.Path(), glipPostMembersIdsListBody);
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