namespace RingCentral
{
    /// <summary>
    ///     Custom greeting data
    /// </summary>
    public class CallRecordingCustomGreetingData
    {
        /// <summary>
        ///     Link to a custom company greeting
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a custom company greeting
        /// </summary>
        public string id { get; set; }
    }
}