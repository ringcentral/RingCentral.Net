namespace RingCentral
{
    public class MeetingsPagingInfo
    {
        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? totalPages { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? totalElements { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? pageStart { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? pageEnd { get; set; }
    }
}