namespace RingCentral
{
    public class SuperviseCallSession
    {
        /// <summary>
        /// Information about a call party that monitors a call
        /// </summary>
        public PartyInfo from;

        /// <summary>
        /// Information about a call party that is monitored
        /// </summary>
        public PartyInfo to;

        /// <summary>
        /// Direction of a call
        /// Enum: Outbound, Inbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Internal identifier of a party that monitors a call
        /// </summary>
        public string id;

        /// <summary>
        /// Specifies if a call party is muted
        /// </summary>
        public bool? muted;

        /// <summary>
        /// </summary>
        public OwnerInfo owner;

        /// <summary>
        /// Specifies if a device is stand-alone
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// </summary>
        public CallStatusInfo status;
    }
}