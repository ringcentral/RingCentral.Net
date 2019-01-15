using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UnconditionalForwardingInfo : Serializable
    {
        // Phone number to which the call is forwarded
        public string phoneNumber;
    }
}