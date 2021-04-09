namespace RingCentral
{
    public class AccountBusinessAddressResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ContactBusinessAddressInfo businessAddress { get; set; }

        /// <summary>
        /// </summary>
        public string company { get; set; }

        /// <summary>
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Custom site name
        /// </summary>
        public string mainSiteName { get; set; }
    }
}