namespace RingCentral
{
    public class CreateSipRegistrationResponse : Serializable
    {
        // Suggested interval in seconds to periodically call SIP-provision API and update the local cache
        public long? pollingInterval;
        public string[] sipErrorCodes;
        // SIP settings for device
        public SIPInfoResponse[] sipInfo; // Required
        // SIP flags data
        public SIPFlagsResponse[] sipFlags; // Required
    }
}