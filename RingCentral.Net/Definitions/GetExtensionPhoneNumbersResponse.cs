namespace RingCentral
{
    public class GetExtensionPhoneNumbersResponse
    {
        /// <summary>
        ///     Link to the user's phone number list resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of phone numbers
        ///     Required
        /// </summary>
        public UserPhoneNumberInfo[] records { get; set; }

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