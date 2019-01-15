using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PhoneNumberResource : Serializable
    {
        public string formattedPhoneNumber;
        public string phoneNumber;
        public string type;
    }
}