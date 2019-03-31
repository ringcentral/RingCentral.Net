namespace RingCentral
{
    public class SearchViaGet2Parameters
    {
        /// <summary>
        /// only support 'userName' or 'email' filter expressions for now
        /// </summary>
        public string filter;

        /// <summary>
        /// start index (1-based)
        /// Default: 1
        /// </summary>
        public long? startIndex;

        /// <summary>
        /// page size
        /// Default: 100
        /// </summary>
        public long? count;
    }
}