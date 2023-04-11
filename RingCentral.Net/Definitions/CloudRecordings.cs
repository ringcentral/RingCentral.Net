namespace RingCentral
{
    /// <summary>
    ///     Recordings page
    /// </summary>
    public class CloudRecordings
    {
        /// <summary>
        ///     Recordings array
        ///     Required
        /// </summary>
        public CloudRecording[] recordings { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Paging paging { get; set; }
    }
}