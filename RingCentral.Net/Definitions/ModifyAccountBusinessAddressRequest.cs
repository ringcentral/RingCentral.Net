namespace RingCentral
{
    public class ModifyAccountBusinessAddressRequest
    {
        /// <summary>
        ///     Company business name
        /// </summary>
        public string company { get; set; }

        /// <summary>
        ///     Company business email address
        /// </summary>
        public string email { get; set; }

        /// <summary>
        /// </summary>
        public BusinessAddressInfo businessAddress { get; set; }

        /// <summary>
        ///     Custom site name
        /// </summary>
        public string mainSiteName { get; set; }
    }
}