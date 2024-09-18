namespace RingCentral
{
    public class CallRecordingSettingsResource
    {
        /// <summary>
        /// </summary>
        public OnDemandResource onDemand { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticRecordingResource automatic { get; set; }

        /// <summary>
        ///     Collection of Greeting Info
        /// </summary>
        public CallRecordingGreetingResource[] greetings { get; set; }
    }
}