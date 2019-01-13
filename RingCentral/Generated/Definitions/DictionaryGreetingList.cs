using Newtonsoft.Json;

namespace RingCentral
{
    public class DictionaryGreetingList : Serializable
    {
        // Canonical URI of greetings list resource
        public string uri;
        // List of greetings
        public DictionaryGreetingInfo[] records;
    }
}