namespace RingCentral
{
    public class MeetingOccurrenceInfo
    {
        /// <summary>
        ///     Identifier of a meeting occurrence
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Starting time of a meeting occurrence
        ///     Format: date-time
        /// </summary>
        public string startTime { get; set; }

        /// <summary>
        ///     Duration of a meeting occurrence
        ///     Format: int64
        /// </summary>
        public long? durationInMinutes { get; set; }

        /// <summary>
        ///     Status of a meeting occurrence
        /// </summary>
        public string status { get; set; }
    }
}