namespace RingCentral
{
    public class CreateSipRegistrationResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public SipRegistrationDeviceInfo device { get; set; }

        /// <summary>
        ///     SIP settings for device
        ///     Required
        /// </summary>
        public SipInfoResponse[] sipInfo { get; set; }

        /// <summary>
        ///     SIP PSTN settings for device
        /// </summary>
        public SipInfoResponse[] sipInfoPstn { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SipFlagsResponse sipFlags { get; set; }

        /// <summary>
        /// </summary>
        public string[] sipErrorCodes { get; set; }

        /// <summary>
        ///     Suggested interval in seconds to periodically call SIP-provision API and update the local cache
        ///     Format: int32
        /// </summary>
        public long? pollingInterval { get; set; }
    }
}