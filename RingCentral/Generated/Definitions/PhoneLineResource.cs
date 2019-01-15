using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PhoneLineResource : Serializable
    {
        public string lineType;
        public PhoneNumberResourceIntId phoneInfo;
        public EmergencyAddress emergencyAddress;
    }
}