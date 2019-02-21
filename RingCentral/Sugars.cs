using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.Fax
{
    public partial class Index
    {
        public Task<RingCentral.FaxResponse> Post(SendFaxMessageRequest sendFaxMessageRequest, Attachment[] attachments)
        {
            sendFaxMessageRequest.attachments = attachments;
            return Post(sendFaxMessageRequest);
        }
    }
}