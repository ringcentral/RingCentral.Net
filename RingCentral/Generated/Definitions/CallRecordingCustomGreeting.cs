using Newtonsoft.Json;

namespace RingCentral
{
    public class CallRecordingCustomGreeting : Serializable
    {
        public string type;
        // Custom greeting data
        public CallRecordingCustomGreetingData custom;
        // Custom greeting language
        public CallRecordingCustomGreetingLanguage language;
    }
}