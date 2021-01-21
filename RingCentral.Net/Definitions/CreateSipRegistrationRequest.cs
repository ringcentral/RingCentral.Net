namespace RingCentral
{
    public class CreateSipRegistrationRequest
    {
        /// <summary>
        /// </summary>
        public DeviceInfoRequest device { get; set; }

        /// <summary>
        /// SIP settings for device
        /// </summary>
        public SIPInfoRequest[] sipInfo { get; set; }
    }
}