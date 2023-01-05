namespace RingCentral
{
    public class FederatedAccountResource
    {
        /// <summary>
        /// </summary>
        public string companyName { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? conflictCount { get; set; }

        /// <summary>
        /// </summary>
        public string federatedName { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Format: date-time
        /// </summary>
        public string linkCreationTime { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumberResource mainNumber { get; set; }
    }
}