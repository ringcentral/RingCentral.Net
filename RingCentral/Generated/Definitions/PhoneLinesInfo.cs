using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PhoneLinesInfo : Serializable
    {
        // Type of phone line
        public string lineType;
        // Phone number information
        public PhoneNumberInfoIntId phoneInfo;
    }
}