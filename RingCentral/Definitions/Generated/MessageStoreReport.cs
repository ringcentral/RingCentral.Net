using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageStoreReport : Serializable
    {
        // Internal identifier of a message store report task
        public string id;
        // Link to a task
        public string uri;
        // Status of a message store report task
        // Enum: Accepted, Pending, InProgress, AttemptFailed, Failed, Completed, Cancelled
        public string status;
        // Internal identifier of an account
        public string accountId;
        // Internal identifier of an extension
        public string extensionId;
        // Task creation time
        public string creationTime;
        // Time of the last task modification
        public string lastModifiedTime;
        // Ending time for collecting messages
        public string dateTo;
        // Starting time for collecting messages
        public string dateFrom;
    }
}