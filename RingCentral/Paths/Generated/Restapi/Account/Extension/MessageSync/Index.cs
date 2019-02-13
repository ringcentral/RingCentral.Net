using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageSync
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
            return $"{parent.Path()}/message-sync";
        }

        public class GetQueryParams
        {
            // Conversation identifier for the resulting messages. Meaningful for SMS and Pager messages only.
            public string conversationId;

            // The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
            public string dateFrom;

            // The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
            public string dateTo;

            // Direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
            public string direction;

            // If 'True', then the latest messages per every conversation ID are returned
            public string distinctConversations;

            // Type for the resulting messages. If not specified, all types of messages are returned. Multiple values are accepted
            public string messageType;

            // Limits the number of records to be returned (works in combination with dateFrom and dateTo if specified)
            public string recordCount;

            // Value of syncToken property of last sync request response
            public string syncToken;

            // Type of message synchronization
            public string syncType;
        }

        public async Task<RingCentral.GetMessageSyncResponse> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.GetMessageSyncResponse>(this.Path(), queryParams);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageSync.Index MessageSync()
        {
            return new Restapi.Account.Extension.MessageSync.Index(this);
        }
    }
}