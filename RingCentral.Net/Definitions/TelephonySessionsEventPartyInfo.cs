namespace RingCentral
{
    public class TelephonySessionsEventPartyInfo
    {
        /// <summary>
        ///     Internal identifier of an account
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Internal identifier of a party
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Call direction
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        /// </summary>
        public CallPartyInfo to { get; set; }

        /// <summary>
        /// </summary>
        public CallPartyInfo from { get; set; }

        /// <summary>
        /// </summary>
        public RecordingInfo[] recordings { get; set; }

        /// <summary>
        /// </summary>
        public CallStatusInfo status { get; set; }

        /// <summary>
        /// </summary>
        public ParkInfo park { get; set; }

        /// <summary>
        ///     Specifies if it's a queue call
        /// </summary>
        public bool? queueCall { get; set; }

        /// <summary>
        ///     Specifies if a call was missed by the party
        /// </summary>
        public bool? missedCall { get; set; }

        /// <summary>
        ///     If `true` then the party is not connected to a session voice
        ///     conference, `false` means the party is connected to other parties in a
        ///     session
        /// </summary>
        public bool? standAlone { get; set; }

        /// <summary>
        ///     Specifies if a call participant is muted or not. **Note:**
        ///     If a call is also controlled via Hard phone or RingCentral App (not only
        ///     through the API by calling call control methods) then it cannot be fully
        ///     muted/unmuted via API only, in this case the action should be duplicated
        ///     via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted { get; set; }

        /// <summary>
        ///     Defines party role in Server Side Conference
        ///     Enum: Host, Participant
        /// </summary>
        public string conferenceRole { get; set; }

        /// <summary>
        /// </summary>
        public SipData sipData { get; set; }

        /// <summary>
        /// </summary>
        public UiCallInfo uiCallInfo { get; set; }
    }
}