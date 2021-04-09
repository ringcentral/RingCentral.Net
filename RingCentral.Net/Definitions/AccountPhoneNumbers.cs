namespace RingCentral
{
    public class AccountPhoneNumbers
    {
        /// <summary>
        ///     Link to the list of account phone numbers
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of account phone numbers
        /// </summary>
        public CompanyPhoneNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}