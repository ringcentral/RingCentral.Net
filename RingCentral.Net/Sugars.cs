using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Fax
{
    public partial class Index
    {
        public Task<FaxResponse> Post(CreateFaxMessageRequest createFaxMessageRequest, Attachment[] attachments)
        {
            createFaxMessageRequest.attachments = attachments;
            return Post(createFaxMessageRequest);
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