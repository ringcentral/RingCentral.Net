namespace RingCentral
{
    public class CallParty : Serializable
    {
        // Internal identifier of a party
        public string id;

        // Status data of a call session
        public CallStatusInfo status;

        // Specifies if a call participant is muted or not
        public bool? muted;

        // True if party is not connected to a session voice conference. False - otherwise
        public bool? standAlone;

        // Call park information
        public ParkInfo park;

        // Data on a calling party
        public PartyInfo from;

        // Data on a called party
        public PartyInfo to;

        // Data on a call owner
        public OwnerInfo owner;

        // Direction of a call
        // Enum: Inbound, Outbound
        public string direction;

        // A party's role in the conference scenarios. For calls of 'Conference' type only
        // Enum: Host, Participant
        public string conferenceRole;

        // A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringout' type only
        // Enum: Initiator, Target
        public string ringOutRole;

        // A party's role in 'Ring Me'/'RingOut' scenarios. For calls of 'Ringme' type only
        // Enum: Initiator, Target
        public string ringMeRole;

        // Active recordings list
        public RecordingInfo[] recordings;
    }
}