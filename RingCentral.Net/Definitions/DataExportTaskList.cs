namespace RingCentral
{
    public class DataExportTaskList
    {
        /// <summary>
        /// </summary>
        public DataExportTask[] tasks { get; set; }

        /// <summary>
        /// </summary>
        public GlipDataExportNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public GlipDataExportPagingInfo paging { get; set; }
    }
}