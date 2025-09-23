namespace RingCentral
{
    /// <summary>
    ///     Information on a party of a call session
    /// </summary>
    public class CallParty
    {
        /// <summary>
        ///     Internal identifier of a party
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Internal identifier of an account
        /// </summary>
        public string accountId { get; set; }

        /// <summary>
        ///     Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// </summary>
        public Attributes attributes { get; set; }

        /// <summary>
        /// </summary>
        public CallStatusInfo status { get; set; }

        /// <summary>
        ///     Specifies if a call participant is muted or not. **Note:**
        ///     If a call is also controlled via Hard phone or RingCentral App (not only
        ///     through the API by calling call control methods) then it cannot be fully
        ///     muted/unmuted via API only, in this case the action should be duplicated
        ///     via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted { get; set; }

        /// <summary>
        ///     If `true` then the party is not connected to a session voice
        ///     conference, `false` means the party is connected to other parties in a
        ///     session
        /// </summary>
        public bool? standAlone { get; set; }

        /// <summary>
        /// </summary>
        public ParkInfo park { get; set; }

        /// <summary>
        /// </summary>
        public PartyInfo from { get; set; }

        /// <summary>
        /// </summary>
        public PartyInfo to { get; set; }

        /// <summary>
        /// </summary>
        public OwnerInfo owner { get; set; }

        /// <summary>
        ///     Direction of a call
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string direction { get; set; }

        /// <summary>
        ///     A party's role in the conference scenarios. For calls of 'Conference' type only
        ///     Enum: Host, Participant
        /// </summary>
        public string conferenceRole { get; set; }

        /// <summary>
        ///     A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringout' type only
        ///     Enum: Initiator, Target
        /// </summary>
        public string ringOutRole { get; set; }

        /// <summary>
        ///     A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringme' type only
        ///     Enum: Initiator, Target
        /// </summary>
        public string ringMeRole { get; set; }

        /// <summary>
        ///     Active recordings list
        /// </summary>
        public RecordingInfo[] recordings { get; set; }

        /// <summary>
        ///     Call metadata.
        /// </summary>
        public MetaData[] metadata { get; set; }
    }
}