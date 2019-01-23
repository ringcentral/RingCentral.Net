namespace RingCentral
{
    public class CallRecordingSettingsResource : Serializable
    {
        public OnDemandResource onDemand;
        public AutomaticRecordingResource automatic;
        // Collection of Greeting Info
        public GreetingResource[] greetings;
    }
}