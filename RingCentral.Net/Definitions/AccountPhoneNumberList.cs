namespace RingCentral
{
    public class AccountPhoneNumberList
    {
        /// <summary>
        ///     List of account phone numbers
        ///     Required
        /// </summary>
        public AccountPhoneNumberInfo[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}