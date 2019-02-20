using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore.Content
{
    public partial class Index
    {
        public RestClient rc;
        public string attachmentId;
        public Restapi.Account.Extension.MessageStore.Index parent;

        public Index(Restapi.Account.Extension.MessageStore.Index parent, string attachmentId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.attachmentId = attachmentId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && attachmentId != null)
            {
                return $"{parent.Path()}/content/{attachmentId}";
            }

            return $"{parent.Path()}/content";
        }

        public async Task<byte[]> Get(GetQueryParams queryParams = null)
        {
            if (this.attachmentId == null)
            {
                throw new System.ArgumentNullException("attachmentId");
            }

            return await rc.Get<byte[]>(this.Path(), queryParams);
        }

        public async Task<byte[]> Get(object queryParams)
        {
            if (this.attachmentId == null)
            {
                throw new System.ArgumentNullException("attachmentId");
            }

            return await rc.Get<byte[]>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Content disposition of a response
        // Enum: Inline, Attachment
        public string contentDisposition;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageStore.Content.Index Content(string attachmentId = null)
        {
            return new Restapi.Account.Extension.MessageStore.Content.Index(this, attachmentId);
        }
    }
}