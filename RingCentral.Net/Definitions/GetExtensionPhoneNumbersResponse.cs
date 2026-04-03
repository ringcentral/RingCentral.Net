namespace RingCentral
{
    public class GetExtensionPhoneNumbersResponse
    {
        /// <summary>
        ///     Link to the user phone number list resource
        ///     Format: uri
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
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}