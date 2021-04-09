namespace RingCentral
{
    public class UserAddress
    {
        /// <summary>
        /// </summary>
        public string country { get; set; }

        /// <summary>
        /// </summary>
        public string locality { get; set; }

        /// <summary>
        /// </summary>
        public string postalCode { get; set; }

        /// <summary>
        /// </summary>
        public string region { get; set; }

        /// <summary>
        /// </summary>
        public string streetAddress { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: work
        /// </summary>
        public string type { get; set; }
    }
}