namespace RingCentral
{
    public class CreateSipRegistrationResponse
    {
        /// <summary>
        /// </summary>
        public SipRegistrationDeviceInfo device { get; set; }

        /// <summary>
        /// SIP settings for device
        /// Required
        /// </summary>
        public SIPInfoResponse[] sipInfo { get; set; }

        /// <summary>
        /// SIP PSTN settings for device
        /// </summary>
        public SIPInfoResponse[] sipInfoPstn { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public SIPFlagsResponse sipFlags { get; set; }

        /// <summary>
        /// </summary>
        public string[] sipErrorCodes { get; set; }
    }
}