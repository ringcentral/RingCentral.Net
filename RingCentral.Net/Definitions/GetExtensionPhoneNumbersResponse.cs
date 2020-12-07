namespace RingCentral
{
    public class GetExtensionPhoneNumbersResponse
    {
        /// <summary>
        /// Link to the user's phone number list resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of phone numbers
        /// Required
        /// </summary>
        public UserPhoneNumberInfo[] records;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}