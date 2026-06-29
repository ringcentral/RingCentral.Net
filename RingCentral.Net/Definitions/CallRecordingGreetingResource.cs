namespace RingCentral
{
    public class CallRecordingGreetingResource
    {
        /// <summary>
        ///     Enum: StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Greeting prompt mode for the given `type`. When at least one custom greeting
        ///     exists for this type (in any language), the literal value `Custom` is returned.
        ///     Otherwise the localized display name of the system default prompt is returned
        ///     (for example `Default` in English or `Par défaut` in French), based on the
        ///     request locale.
        ///     Example: Default
        /// </summary>
        public string mode { get; set; }
    }
}