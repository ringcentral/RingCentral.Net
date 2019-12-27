namespace RingCentral
{
    public class AccountPhoneNumbers
    {
        /// <summary>
        /// Link to the list of account phone numbers
        /// </summary>
        public string uri;

        /// <summary>
        /// List of account phone numbers
        /// </summary>
        public CompanyPhoneNumberInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}