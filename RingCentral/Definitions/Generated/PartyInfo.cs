using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class PartyInfo : Serializable
    {
        // Phone number of a party
        public string phoneNumber;
        // Internal extension identifier
        public string extensionId;
        // Displayed name of a party
        public string name;
    }
}