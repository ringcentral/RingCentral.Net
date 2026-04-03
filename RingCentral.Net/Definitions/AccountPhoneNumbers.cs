namespace RingCentral
{
    public class AccountPhoneNumbers
    {
        /// <summary>
        ///     Link to a list of account phone numbers
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of account phone numbers
        /// </summary>
        public CompanyPhoneNumberInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}