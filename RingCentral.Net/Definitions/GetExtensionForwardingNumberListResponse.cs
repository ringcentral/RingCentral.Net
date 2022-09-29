namespace RingCentral
{
    public class GetExtensionForwardingNumberListResponse
    {
        /// <summary>
        ///     Link to the forwarding number list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of forwarding phone numbers
        /// </summary>
        public ForwardingNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public NavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }
    }
}