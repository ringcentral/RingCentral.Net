using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class MakeRingOutCallerInfoRequestTo : Serializable
    {
        // Phone number in E.164 format
        public string phoneNumber;
    }
}