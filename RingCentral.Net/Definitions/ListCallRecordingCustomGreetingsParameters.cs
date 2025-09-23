namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listCallRecordingCustomGreetings
    /// </summary>
    public class ListCallRecordingCustomGreetingsParameters
    {
        /// <summary>
        ///     Type of custom greetings to filter results
        ///     Enum: StartRecording, StopRecording, AutomaticRecording
        /// </summary>
        public string type { get; set; }
    }
}