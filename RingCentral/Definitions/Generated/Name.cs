using Newtonsoft.Json;

namespace RingCentral
{
    public class Name : Serializable
    {
        public string familyName; // Required
        public string givenName; // Required
    }
}