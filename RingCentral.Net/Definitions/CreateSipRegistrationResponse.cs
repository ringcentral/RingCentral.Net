namespace RingCentral
{
    public class CreateSipRegistrationResponse
    {
        /// <summary>
        /// Suggested interval in seconds to periodically call SIP-provision API and update the local cache
        /// </summary>
        public long? pollingInterval;

        /// <summary>
        /// </summary>
        public string[] sipErrorCodes;

        /// <summary>
        /// SIP settings for device
        /// Required
        /// </summary>
        public SIPInfoResponse[] sipInfo;

        /// <summary>
        /// SIP flags data
        /// Required
        /// </summary>
        public SIPFlagsResponse[] sipFlags;
    }
}