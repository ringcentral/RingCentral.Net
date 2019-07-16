namespace RingCentral
{
    public class CallParty
    {
        /// <summary>
        /// Internal identifier of a party
        /// </summary>
        public string id;

        /// <summary>
        /// Status data of a call session
        /// </summary>
        public CallStatusInfo status;

        /// <summary>
        /// Specifies if a call participant is muted or not
        /// </summary>
        public bool? muted;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// Call park information
        /// </summary>
        public ParkInfo park;

        /// <summary>
        /// Data on a calling party
        /// </summary>
        public PartyInfo from;

        /// <summary>
        /// Data on a called party
        /// </summary>
        public PartyInfo to;

        /// <summary>
        /// Data on a call owner
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