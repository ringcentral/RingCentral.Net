using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Recording.Content
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Recording.Index parent;

        public Index(Restapi.Account.Recording.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/content";
        }

        /// <summary>
        /// Operation: Get Call Recordings Data
        /// Http Get /restapi/v1.0/account/{accountId}/recording/{recordingId}/content
        /// </summary>
        public async Task<byte[]> Get()
        {
            return await rc.Get<byte[]>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Recording
{
    public partial class Index
    {
        public Restapi.Account.Recording.Content.Index Content()
        {
            return new Restapi.Account.Recording.Content.Index(this);
        }
    }
}