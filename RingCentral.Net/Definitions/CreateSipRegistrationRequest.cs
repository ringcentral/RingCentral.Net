namespace RingCentral
{
    public class CreateSipRegistrationRequest
    {
        /// <summary>
        /// Device unique description
        /// Required
        /// </summary>
        public DeviceInfoRequest device;

        /// <summary>
        /// SIP settings for device
        /// Required
        /// </summary>
        public SIPInfoRequest[] sipInfo;
    }
}