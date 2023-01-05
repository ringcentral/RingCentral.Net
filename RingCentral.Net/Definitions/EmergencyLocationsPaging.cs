namespace RingCentral
{
    public class EmergencyLocationsPaging
    {
        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? totalPages { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? totalElements { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? pageStart { get; set; }

        /// <summary>
        ///     Required
        ///     Format: int32
        /// </summary>
        public long? pageEnd { get; set; }
    }
}