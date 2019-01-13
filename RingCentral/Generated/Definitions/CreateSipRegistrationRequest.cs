using Newtonsoft.Json;

namespace RingCentral
{
    public class CreateSipRegistrationRequest : Serializable
    {
        // Device unique description
        public DeviceInfoRequest[] device;
        // SIP settings for device
        public SIPInfoRequest[] sipInfo;
    }
}