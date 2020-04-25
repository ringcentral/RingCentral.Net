using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.Mms
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/mms";
        }

        /// <summary>
        /// Operation: Create MMS Message
        /// Rate Limit Group: Medium
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/mms
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Post(RingCentral.CreateMMSMessage createMMSMessage,
            CancellationToken? cancellationToken = null)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createMMSMessage);
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), multipartFormDataContent, null,
                cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.Mms.Index Mms()
        {
            return new Restapi.Account.Extension.Mms.Index(this);
        }
    }
}