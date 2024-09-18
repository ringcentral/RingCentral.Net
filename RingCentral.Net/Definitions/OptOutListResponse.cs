namespace RingCentral
{
    /// <summary>
    ///     The list of opt outs
    /// </summary>
    public class OptOutListResponse
    {
        /// <summary>
        ///     List of individual opt-out number records
        /// </summary>
        public OptOutResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}