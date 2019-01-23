using Newtonsoft.Json;

namespace RingCentral
{
    // Returns data on call recording custom greetings.
    public class CallRecordingCustomGreetings : Serializable
    {
        public CallRecordingCustomGreeting[] records;
    }
}