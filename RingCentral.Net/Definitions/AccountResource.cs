namespace RingCentral
{
    public class AccountResource
    {
        /// <summary>
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        /// </summary>
        public string federatedName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberResource mainNumber { get; set; }
    }
}