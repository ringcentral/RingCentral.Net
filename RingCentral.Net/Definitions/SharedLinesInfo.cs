namespace RingCentral
{
    /// <summary>
    ///     SharedLines call handling action settings
    /// </summary>
    public class SharedLinesInfo
    {
        /// <summary>
        ///     Number of seconds to wait before forwarding unanswered calls. The value range is 10 - 80
        /// </summary>
        public long? timeout { get; set; }
    }
}