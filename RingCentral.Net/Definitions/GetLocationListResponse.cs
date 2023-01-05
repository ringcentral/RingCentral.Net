namespace RingCentral
{
    public class GetLocationListResponse
    {
        /// <summary>
        ///     Link to the location list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of locations
        /// </summary>
        public LocationInfo[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}