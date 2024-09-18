namespace RingCentral
{
    /// <summary>
    ///     The list of batches retrieved for an account and other filter criteria such as fromPhoneNumber, date specified in
    ///     the request.
    /// </summary>
    public class BatchListResponse
    {
        /// <summary>
        ///     An array containing individual batches
        /// </summary>
        public MessageBatchResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}