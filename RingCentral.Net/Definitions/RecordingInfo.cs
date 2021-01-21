namespace RingCentral
{
    public class RecordingInfo
    {
        /// <summary>
        /// Internal identifier of a recording resource
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// True if the recording is active. False if the recording is paused.
        /// </summary>
        public bool? active { get; set; }
    }
}