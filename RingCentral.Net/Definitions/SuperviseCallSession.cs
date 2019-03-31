namespace RingCentral
{
    public class SuperviseCallSession
    {
        /* Information about a call party that monitors a call */
        public PartyInfo from;

        /* Information about a call party that is monitored */
        public PartyInfo to;

        /* Direction of a call */
        // Enum: Outbound, Inbound
        public string direction;

        /* Internal identifier of a party that monitors a call */
        public string id;

        /* Specifies if a call party is muted */
        public bool? muted;

        public OwnerInfo owner;

        /* Specifies if a device is stand-alone */
        public bool? standAlone;

        public CallStatusInfo status;
    }
}