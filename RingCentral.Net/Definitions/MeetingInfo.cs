namespace RingCentral
{
    public class MeetingInfo
    {
        /// <summary>
        ///     Unique identifier of a meeting instance
        /// </summary>
        public string uuid { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public string topic { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }
    }
}