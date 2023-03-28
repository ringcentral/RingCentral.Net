namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse
    {
        /// <summary>
        ///     Link to the forwarding number list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of forwarding phone numbers
        /// </summary>
        public ForwardingNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}