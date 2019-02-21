namespace RingCentral
{
    public class ListCountriesParameters
    {
        // Specifies whether login with the phone numbers of this country is enabled or not
        public bool? loginAllowed;

        // Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any)
        public bool? signupAllowed;

        // Specifies if RingCentral sells phone numbers of this country
        public bool? numberSelling;

        // Indicates the page number to retrieve. Only positive number values are accepted
        // Default: 1
        public long? page;

        // Indicates the page size (number of items)
        // Default: 100
        public long? perPage;

        // Specifies if free phone line for softphone is available for a country or not
        public bool? freeSoftphoneLine;
    }
}