namespace RingCentral
{
    public class CallSessionObject
    {
        // Internal identifier of a call session
        public string id;

        // Initial data of a call session
        public OriginInfo origin;

        // For calls of 'Conference' type only
        public string voiceCallToken;

        // Information on a party of a call session
        public CallParty parties;

        // Date and time of the latest session update represented in Unix time format
        public string creationTime;
    }
}