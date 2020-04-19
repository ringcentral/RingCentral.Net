namespace RingCentral
{
    public class ModifyAccountBusinessAddressRequest
    {
        /// <summary>
        /// Company business name
        /// </summary>
        public string company;

        /// <summary>
        /// Company business email address
        /// </summary>
        public string email;

        /// <summary>
        /// Company business address
        /// </summary>
        public BusinessAddressInfo businessAddress;

        /// <summary>
        /// Custom site name
        /// </summary>
        public string mainSiteName;
    }
}