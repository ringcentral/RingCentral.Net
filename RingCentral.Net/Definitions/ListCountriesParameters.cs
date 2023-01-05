namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listCountries
    /// </summary>
    public class ListCountriesParameters
    {
        /// <summary>
        ///     Specifies whether the logging-in with the phone numbers of this country
        ///     is enabled or not
        /// </summary>
        public bool? loginAllowed { get; set; }

        /// <summary>
        ///     Indicates whether a signup/billing is allowed for a country. If
        ///     not specified all countries are returned (according to other
        ///     specified filters if any)
        /// </summary>
        public bool? signupAllowed { get; set; }

        /// <summary>
        ///     Specifies if RingCentral sells phone numbers of this country
        /// </summary>
        public bool? numberSelling { get; set; }

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
        ///     Specifies if free phone line for softphone is available for a
        ///     country or not
        /// </summary>
        public bool? freeSoftphoneLine { get; set; }
    }
}