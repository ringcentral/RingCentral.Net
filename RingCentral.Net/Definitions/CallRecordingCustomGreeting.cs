namespace RingCentral
{
    public class CallRecordingCustomGreeting
    {
        // Enum: StartRecording, StopRecording, AutomaticRecording
        public string type;

        /* Custom greeting data */
        public CallRecordingCustomGreetingData custom;

        /* Custom greeting language */
        public CallRecordingCustomGreetingLanguage language;
    }
}