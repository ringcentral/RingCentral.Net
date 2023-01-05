namespace RingCentral
{
    public class AccountResource
    {
        /// <summary>
        ///     Example: My lovely company
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        ///     Example: Lovely Holding
        /// </summary>
        public string federatedName { get; set; }

        /// <summary>
        ///     Required
        ///     Example: 400131426008
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberResource mainNumber { get; set; }
    }
}