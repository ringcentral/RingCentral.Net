namespace RingCentral
{
    public class ListStatesParameters
    {
        /// <summary>
        /// If set to 'True' then states for all countries are returned and `countryId` is ignored, even if specified. If the value is empty then the parameter is ignored
        /// </summary>
        public bool? allCountries;

        /// <summary>
        /// Internal identifier of a country
        /// </summary>
        public long? countryId;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// If 'True', the list of states with phone numbers available for buying is returned
        /// </summary>
        public bool? withPhoneNumbers;
    }
}