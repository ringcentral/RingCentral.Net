namespace RingCentral
{
    public class CreateDataExportTaskRequest
    {
        /// <summary>
        /// Starting time for data collection. The default value is current time minus 24 hours. If `dateTo` is not specified then its value is set to `dateFrom` plus 24 hours. The specified time range should not be greater than 7 days
        /// </summary>
        public string dateFrom;

        /// <summary>
        /// Ending time for data collection. The default value is current time. If `dateFrom` is not specified then its value is set to `dateTo` minus 24 hours. The specified time range should not be greater than 7 days
        /// </summary>
        public string dateTo;

        /// <summary>
        /// List of users which data is collected. The following data will be exported: posts, tasks, events, etc. posted by the user(s); posts addressing the user(s) via direct and @Mentions; tasks assigned to the listed user(s). The list of 30 users per request is supported.
        /// </summary>
        public string[] userIds;

        /// <summary>
        /// List of chats from which the data (posts, files, tasks, events, notes, etc.) will be collected
        /// </summary>
        public string[] chatIds;
    }
}