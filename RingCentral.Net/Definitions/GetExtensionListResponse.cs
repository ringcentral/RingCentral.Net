namespace RingCentral
{
    public class GetExtensionListResponse
    {
        /// <summary>
        ///     Link to an extension list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of extensions with extension information
        ///     Required
        /// </summary>
        public GetExtensionListInfoResponse[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}