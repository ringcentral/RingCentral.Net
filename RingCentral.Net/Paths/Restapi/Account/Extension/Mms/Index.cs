using System.Threading.Tasks;

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
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/mms
        /// </summary>
        public async Task<RingCentral.GetMessageInfoResponse> Post(RingCentral.CreateSMSMessage createSMSMessage)
        {
            var multipartFormDataContent = Utils.GetMultipartFormDataContent(createSMSMessage);
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), multipartFormDataContent);
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