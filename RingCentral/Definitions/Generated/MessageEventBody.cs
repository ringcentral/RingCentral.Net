using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageEventBody : Serializable
    {
        // Internal identifier of an extension
        public string extensionId;
        // Datetime when the message was last modified in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        public string lastUpdated;
        // Message Changes
        public MessageChanges[] changes;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}