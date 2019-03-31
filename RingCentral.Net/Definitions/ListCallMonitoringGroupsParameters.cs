namespace RingCentral
{
    public class ListCallMonitoringGroupsParameters
    {
        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are allowed
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Internal identifier of an extension that is a member of every group within the result
        /// </summary>
        public string memberExtensionId;
    }
}