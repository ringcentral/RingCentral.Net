namespace RingCentral
{
    public class SuperviseCallSessionResponse
    {
        /// <summary>
        /// </summary>
        public PartyInfo from { get; set; }

        /// <summary>
        /// </summary>
        public PartyInfo to { get; set; }

        /// <summary>
        ///     Direction of a call
        ///     Enum: Outbound, Inbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     Internal identifier of a party that monitors a call
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of an account that monitors a call
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension that monitors a call
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or
        ///     RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted
        ///     via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted { get; set; }

        /// <summary>
        /// </summary>
        public OwnerInfo owner { get; set; }

        /// <summary>
        ///     If `true` then the party is not connected to a session voice conference, `false` means the party is connected to
        ///     other parties in a session
        /// </summary>
        public bool? standAlone { get; set; }

        /// <summary>
        /// </summary>
        public CallStatusInfo status { get; set; }
    }
}