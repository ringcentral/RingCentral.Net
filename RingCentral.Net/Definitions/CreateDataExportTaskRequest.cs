namespace RingCentral
{
    public class CreateDataExportTaskRequest
    {
        /// <summary>
        ///     Starting time for data collection. The default value is `timeTo` minus 24 hours. Max allowed time frame between `timeFrom` and `timeTo` is 6 months
        /// </summary>
        public string timeFrom { get; set; }

        /// <summary>
        ///     Ending time for data collection. The default value is current time. Max allowed time frame between `timeFrom` and `timeTo` is 6 months
        /// </summary>
        public string timeTo { get; set; }

        /// <summary>
        /// </summary>
        public DataExportTaskContactInfo[] contacts { get; set; }

        /// <summary>
        ///     List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected. Maximum number of chats supported is 10
        /// </summary>
        public string[] chatIds { get; set; }
    }
}