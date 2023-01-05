namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listDomesticCountries
    /// </summary>
    public class ListDomesticCountriesParameters
    {
        /// <summary>
        ///     Indicates a page number to retrieve. Only positive number values
        ///     are accepted
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates a page size (number of items)
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}