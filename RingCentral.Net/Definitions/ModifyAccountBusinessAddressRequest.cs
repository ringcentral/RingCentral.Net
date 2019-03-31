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
        /// Required
        /// </summary>
        public BusinessAddressInfo businessAddress;
    }
}