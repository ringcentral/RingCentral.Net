using Newtonsoft.Json;

namespace RingCentral
{
    public class PhoneLineResource : Serializable
    {
        // Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary, BLF
        public string lineType;
        public PhoneNumberResourceIntId phoneInfo;
        public EmergencyAddress emergencyAddress;
    }
}