namespace RingCentral
{
    // Information on a party of a call session
    public class CallParty
    {
        /// <summary>
        /// Internal identifier of a party
        /// </summary>
        public string id;

        /// <summary>
        /// </summary>
        public CallStatusInfo status;

        /// <summary>
        /// Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// </summary>
        public ParkInfo park;

        /// <summary>
        /// </summary>
        public PartyInfo from;

        /// <summary>
        /// </summary>
        public PartyInfo to;

        /// <summary>
        /// </summary>
        public OwnerInfo owner;

        /// <summary>
        /// Direction of a call
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;

        /// <summary>
        /// A party's role in the conference scenarios. For calls of 'Conference' type only
        /// Enum: Host, Participant
        /// </summary>
        public string conferenceRole;

        /// <summary>
        /// A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringout' type only
        /// Enum: Initiator, Target
        /// </summary>
        public string ringOutRole;

        /// <summary>
        /// A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringme' type only
        /// Enum: Initiator, Target
        /// </summary>
        public string ringMeRole;

        /// <summary>
        /// Active recordings list
        /// </summary>
        public RecordingInfo[] recordings;
    }
}