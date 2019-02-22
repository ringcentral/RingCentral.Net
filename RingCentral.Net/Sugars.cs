using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Fax
{
    public partial class Index
    {
        public Task<FaxResponse> Post(SendFaxMessageRequest sendFaxMessageRequest, Attachment[] attachments)
        {
            sendFaxMessageRequest.attachments = attachments;
            return Post(sendFaxMessageRequest);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension.Sms
{
    public partial class Index
    {
        public async Task<GetMessageInfoResponse> Post(CreateSMSMessage createSMSMessage, Attachment[] attachments)
        {
            var multipartFormDataContent =
                Utils.GetMultipartFormDataContent(createSMSMessage, new {attachments = attachments});
            return await rc.Post<RingCentral.GetMessageInfoResponse>(this.Path(), multipartFormDataContent);
        }
    }
}