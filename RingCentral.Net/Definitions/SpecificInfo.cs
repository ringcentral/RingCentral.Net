namespace RingCentral
{
    /// <summary>
    ///     Information specified in request
    /// </summary>
    public class SpecificInfo
    {
        /// <summary>
        ///     Starting time for data collection
        ///     Format: date-time
        /// </summary>
        public string timeFrom { get; set; }

        /// <summary>
        ///     Ending time for data collection
        ///     Format: date-time
        /// </summary>
        public string timeTo { get; set; }

        /// <summary>
        /// </summary>
        public DataExportTaskContactInfo[] contacts { get; set; }

        /// <summary>
        ///     List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected
        /// </summary>
        public string[] chatIds { get; set; }
    }
}