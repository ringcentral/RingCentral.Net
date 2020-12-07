namespace RingCentral
{
    public class PartySuperviseResponse
    {
        /// <summary>
        /// </summary>
        public PartyInfo from;

        /// <summary>
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
        /// Internal identifier of an account that monitors a call
        /// </summary>
        public string accountId;

        /// <summary>
        /// Internal identifier of an extension that monitors a call
        /// </summary>
        public string extensionId;

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