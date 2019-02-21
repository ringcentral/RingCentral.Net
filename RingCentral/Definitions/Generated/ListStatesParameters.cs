namespace RingCentral
{
    public class ListStatesParameters
    {
        // If set to 'True' then states for all countries are returned and `countryId` is ignored, even if specified. If the value is empty then the parameter is ignored
        public bool? allCountries;

        // Internal identifier of a country
        public long? countryId;

        // Indicates the page number to retrieve. Only positive number values are accepted
        // Default: 1
        public long? page;

        // Indicates the page size (number of items)
        // Default: 100
        public long? perPage;

        // If 'True', the list of states with phone numbers available for buying is returned
        public bool? withPhoneNumbers;
    }
}