using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class ModifyAccountBusinessAddressRequest : Serializable
    {
        // Company business name
        public string company;
        // Company business email address
        public string email;
        // Company business address
        public BusinessAddressInfo businessAddress;
    }
}