using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Add
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
            return $"{parent.Path()}/add";
        }

        public async Task<string> Post(RingCentral.GlipPostMembersListBody glipPostMembersListBody)
        {
            return await rc.Post<string>(this.Path(), glipPostMembersListBody);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Add.Index Add()
        {
            return new Restapi.Glip.Teams.Add.Index(this);
        }
    }
}