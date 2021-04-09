namespace RingCentral
{
    public class CallRecording
    {
        /// <summary>
        ///     Internal identifier of a call recording
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Call recording status
        /// </summary>
        public bool? active { get; set; }
    }
}