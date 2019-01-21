using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PhoneLineResource : Serializable
    {
        // Enum: Unknown, Standalone, StandaloneFree, BlaPrimary, BlaSecondary, BLF
        public string lineType;
        public PhoneNumberResourceIntId phoneInfo;
        public EmergencyAddress emergencyAddress;
    }
}