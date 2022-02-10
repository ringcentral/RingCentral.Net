namespace RingCentral
{
    public class PerformanceCallsPaging
    {
        /// <summary>
        ///     The current page number
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items displayed per page
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     The total number of pages
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? totalPages { get; set; }

        /// <summary>
        ///     The total number of items in the dataset
        ///     Required
        ///     Format: int64
        /// </summary>
        public long? totalElements { get; set; }
    }
}