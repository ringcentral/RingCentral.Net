namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        /// <summary>
        /// Link to the timezone list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// List of timezones
        /// Required
        /// </summary>
        public GetTimezoneInfoResponse[] records { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}