using Newtonsoft.Json;

namespace RingCentral
{
    public class AccountBusinessAddressResource : Serializable
    {
        public string uri;
        public ContactBusinessAddressInfo businessAddress;
        public string company;
        public string email;
    }
}