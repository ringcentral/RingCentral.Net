using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PhoneNumber : Serializable
    {
        // Enum: work, mobile, other
        public string type; // Required
        public string value; // Required
    }
}