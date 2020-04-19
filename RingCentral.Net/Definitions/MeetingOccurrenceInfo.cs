namespace RingCentral
{
    public class MeetingOccurrenceInfo
    {
        /// <summary>
        /// Identifier of a meeting occurrence
        /// </summary>
        public string id;

        /// <summary>
        /// Starting time of a meeting occurrence
        /// </summary>
        public string startTime;

        /// <summary>
        /// Duration of a meeting occurrence
        /// </summary>
        public long? durationInMinutes;

        /// <summary>
        /// Status of a meeting occurrence
        /// </summary>
        public string status;
    }
}