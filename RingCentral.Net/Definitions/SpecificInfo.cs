namespace RingCentral
{
    // Information specififed in request
    public class SpecificInfo
    {
        /// <summary>
        /// Starting time for data collection
        /// </summary>
        public string timeFrom;

        /// <summary>
        /// Ending time for data collection
        /// </summary>
        public string timeTo;

        /// <summary>
        /// </summary>
        public DataExportTaskContactInfo[] contacts;

        /// <summary>
        /// List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected
        /// </summary>
        public string[] chatIds;
    }
}