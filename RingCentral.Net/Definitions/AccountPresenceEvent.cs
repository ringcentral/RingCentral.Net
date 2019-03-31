namespace RingCentral
{
    public class AccountPresenceEvent
    {
        /* Universally unique identifier of a notification */
        public string uuid;

        /* Event filter URI */
        public string @event;

        /* Datetime of sending a notification in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format including timezone, for example *2016-03-10T18:07:52.534Z* */
        public string timestamp;

        /* Internal identifier of a subscription */
        public string subscriptionId;

        /* Notification payload body */
        public AccountPresenceEventBody body;
    }
}