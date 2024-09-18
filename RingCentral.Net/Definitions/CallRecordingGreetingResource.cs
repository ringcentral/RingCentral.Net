namespace RingCentral
{
    public class CallRecordingGreetingResource
    {
        /// <summary>
        ///     Enum: StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Here `Default` indicates that all greetings of that type
        ///     (in all languages) are default. If at least one greeting (in any language)
        ///     of the specified type is custom, then `Custom` is returned.
        ///     Enum: Default, Custom
        /// </summary>
        public string mode { get; set; }
    }
}