namespace RingCentral
{
    public class CreateSipRegistrationRequest
    {
        /// <summary>
        /// Device information
        /// </summary>
        public DeviceInfoRequest device;

        /// <summary>
        /// SIP settings for device
        /// </summary>
        public SIPInfoRequest[] sipInfo;
    }
}