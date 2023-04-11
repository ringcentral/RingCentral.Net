namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation caiEnrollmentsList
    /// </summary>
    public class CaiEnrollmentsListParameters
    {
        /// <summary>
        ///     Indicates if partially enrolled speakers should be returned
        /// </summary>
        public bool? partial { get; set; }

        /// <summary>
        ///     Number of enrollments to be returned per page
        ///     Format: int32
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Page number to be returned
        ///     Format: int32
        /// </summary>
        public long? page { get; set; }
    }
}