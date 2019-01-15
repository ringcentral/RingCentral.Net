using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ForwardTarget : Serializable
    {
        // Phone number
        public string phoneNumber;
        // VM owner's extension id
        public string voicemail;
    }
}