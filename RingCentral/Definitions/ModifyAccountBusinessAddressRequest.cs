namespace RingCentral
{
    public class ModifyAccountBusinessAddressRequest
    {
        // Company business name
        public string company;

        // Company business email address
        public string email;

        // Company business address
        public BusinessAddressInfo businessAddress; // Required
    }
}