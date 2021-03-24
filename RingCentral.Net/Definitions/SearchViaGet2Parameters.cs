namespace RingCentral
{
    // Query parameters for operation searchViaGet2
    public class SearchViaGet2Parameters
    {
        /// <summary>
        /// only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter { get; set; }

        /// <summary>
        /// start index (1-based)
        /// Default: 1
        /// </summary>
        public long? startIndex { get; set; }

        /// <summary>
        /// page size
        /// Default: 100
        /// </summary>
        public long? count { get; set; }
    }
}