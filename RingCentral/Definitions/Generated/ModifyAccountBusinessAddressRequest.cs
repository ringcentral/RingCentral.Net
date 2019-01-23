namespace RingCentral
{
    public class ModifyAccountBusinessAddressRequest : Serializable
    {
        // Company business name
        public string company;
        // Company business email address
        public string email;
        // Company business address
        public BusinessAddressInfo businessAddress; // Required
    }
}