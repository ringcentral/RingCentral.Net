namespace RingCentral
{
    // Query parameters for operation listDataExportTasks
    public class ListDataExportTasksParameters
    {
        /// <summary>
        ///     Status of the task(s) to be returned. Multiple values are supported
        ///     Enum: Accepted, InProgress, Completed, Failed, Expired
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     Page number to be retrieved; value range is > 0
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Number of records to be returned per page; value range is 1 - 250
        ///     Default: 30
        /// </summary>
        public long? perPage { get; set; }
    }
}