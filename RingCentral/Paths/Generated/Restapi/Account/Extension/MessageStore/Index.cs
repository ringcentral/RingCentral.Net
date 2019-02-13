using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStore
{
    public partial class Index
    {
        public RestClient rc;
        public string messageId;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent, string messageId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.messageId = messageId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && messageId != null)
            {
                return $"{parent.Path()}/message-store/{messageId}";
            }

            return $"{parent.Path()}/message-store";
        }

        public class ListQueryParams
        {
            // Specifies the availability status for the resulting messages. Multiple values are accepted
            public string availability;

            // Specifies the conversation identifier for the resulting messages
            public string conversationId;

            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string dateFrom;

            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo;

            // The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string direction;

            // If 'True', then the latest messages per every conversation ID are returned
            public string distinctConversations;

            // The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
            public string messageType;

            // The read status for the resulting messages. Multiple values are accepted
            public string readStatus;

            // Indicates the page number to retrieve. Only positive number values are accepted
            public string page;

            // Indicates the page size (number of items)
            public string perPage;

            // The phone number. If specified, messages are returned for this particular phone number only
            public string phoneNumber;
        }

        public async Task<RingCentral.GetMessageList> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetMessageList>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.GetMessageInfoResponse> Get()
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Get<RingCentral.GetMessageInfoResponse>(this.Path());
        }

        public async Task<RingCentral.GetMessageInfoResponse> Put(RingCentral.UpdateMessageRequest updateMessageRequest)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Put<RingCentral.GetMessageInfoResponse>(this.Path(), updateMessageRequest);
        }

        public class DeleteQueryParams
        {
            // If the value is 'True', then the message is purged immediately with all the attachments
            public string purge;

            // Internal identifier of a message thread
            public string conversationId;
        }

        public async Task<string> Delete(DeleteQueryParams queryParams = null)
        {
            if (this.messageId == null)
            {
                throw new System.ArgumentNullException("messageId");
            }

            return await rc.Delete<string>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageStore.Index MessageStore(string messageId = null)
        {
            return new Restapi.Account.Extension.MessageStore.Index(this, messageId);
        }
    }
}