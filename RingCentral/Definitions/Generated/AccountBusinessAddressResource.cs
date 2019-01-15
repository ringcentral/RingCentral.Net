using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class AccountBusinessAddressResource : Serializable
    {
        public string uri;
        public ContactBusinessAddressInfo businessAddress;
        public string company;
        public string email;
    }
}