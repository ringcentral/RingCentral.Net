namespace RingCentral
{
    /// <summary>
    ///     Opt-out phone numbers information
    /// </summary>
    public class OptOutListResponse
    {
        /// <summary>
        ///     List of individual opt-out number records
        /// </summary>
        public OptOutResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public PagingResource paging { get; set; }
    }
}