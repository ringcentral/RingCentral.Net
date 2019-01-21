using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class Name : Serializable
    {
        public string familyName; // Required
        public string givenName; // Required
    }
}