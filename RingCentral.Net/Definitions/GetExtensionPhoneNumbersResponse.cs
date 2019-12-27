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
        /// Information on navigation
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}