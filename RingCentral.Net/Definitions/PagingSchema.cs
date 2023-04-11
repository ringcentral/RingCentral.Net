namespace RingCentral
{
    public class PagingSchema
    {
        /// <summary>
        ///     Required
        ///     Format: int32
        ///     Example: 2
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        ///     Example: 10
        /// </summary>
        public long? totalPages { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        ///     Example: 5
        /// </summary>
        public long? perPage { get; set; }
    }
}