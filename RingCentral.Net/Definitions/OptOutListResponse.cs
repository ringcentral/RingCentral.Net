namespace RingCentral
{
    // Opt-out phone numbers information
    public class OptOutListResponse
    {
        /// <summary>
        /// List of individual opt-out number records
        /// </summary>
        public OptOutResponse[] records;

        /// <summary>
        /// </summary>
        public PagingResource paging;
    }
}