namespace RingCentral
{
    public class CallRecordingCustomGreeting
    {
        /// <summary>
        /// Enum: StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public CallRecordingCustomGreetingData custom { get; set; }

        /// <summary>
        /// </summary>
        public CallRecordingCustomGreetingLanguage language { get; set; }
    }
}