namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listStates
    /// </summary>
    public class ListStatesParameters
    {
        /// <summary>
        ///     If set to `true` then states of all countries are returned and
        ///     `countryId` is ignored, even if specified. If the value is empty
        ///     then the parameter is ignored
        /// </summary>
        public bool? allCountries { get; set; }

        /// <summary>
        ///     Internal identifier of a country
        ///     Format: int64
        /// </summary>
        public long? countryId { get; set; }

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

        /// <summary>
        ///     If `true` the list of states with phone numbers available for
        ///     buying is returned
        /// </summary>
        public bool? withPhoneNumbers { get; set; }
    }
}