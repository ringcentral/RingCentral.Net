namespace RingCentral
{
    public class CreateSipRegistrationResponse
    {
        /// <summary>
        /// </summary>
        public SipRegistrationDeviceInfo device;

        /// <summary>
        /// SIP settings for device
        /// Required
        /// </summary>
        public SIPInfoResponse[] sipInfo;

        /// <summary>
        /// SIP PSTN settings for device
        /// </summary>
        public SIPInfoResponse[] sipInfoPstn;

        /// <summary>
        /// SIP flags data
        /// Required
        /// </summary>
        public SIPFlagsResponse[] sipFlags;

        /// <summary>
        /// </summary>
        public string[] sipErrorCodes;
    }
}