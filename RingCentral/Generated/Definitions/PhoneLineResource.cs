using Newtonsoft.Json;

namespace RingCentral
{
    public class PhoneLineResource : Serializable
    {
        public string lineType;
        public PhoneNumberResourceIntId phoneInfo;
        public EmergencyAddress emergencyAddress;
    }
}