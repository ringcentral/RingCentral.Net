using Newtonsoft.Json;

namespace RingCentral
{
    public class MessageStoreCallerInfoRequest : Serializable
    {
        // Phone number in E.164 format
        public string phoneNumber;
    }
}