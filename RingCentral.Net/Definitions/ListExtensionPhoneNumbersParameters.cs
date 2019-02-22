namespace RingCentral
{
    public class ListExtensionPhoneNumbersParameters
    {
        // Usage type of a phone number
        public string[] usageType;

        // Indicates the page number to retrieve. Only positive number values are allowed. Default value is '1'
        public long? page;

        // Indicates the page size (number of items). If not specified, the value is '100' by default
        public long? perPage;
    }
}