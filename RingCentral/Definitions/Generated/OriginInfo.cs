using Newtonsoft.Json;

namespace RingCentral
{
    public class OriginInfo : Serializable
    {
        // Session origin type
        // Enum: RingOut, RingMe, Conference, GreetingRecording, VerificartionCall, Call
        public string type;
    }
}