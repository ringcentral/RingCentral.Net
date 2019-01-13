using Newtonsoft.Json;

namespace RingCentral
{
    public class PhoneNumberResource : Serializable
    {
        public string formattedPhoneNumber;
        public string phoneNumber;
        public string type;
    }
}