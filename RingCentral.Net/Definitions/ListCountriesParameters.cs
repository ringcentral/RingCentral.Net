namespace RingCentral
{
    public class ListCountriesParameters
    {
        /// <summary>
        /// Specifies whether login with the phone numbers of this country is enabled or not
        /// </summary>
        public bool? loginAllowed { get; set; }

        /// <summary>
        /// Indicates whether signup/billing is allowed for a country. If not specified all countries are returned (according to other filters specified if any)
        /// </summary>
        public bool? signupAllowed { get; set; }

        /// <summary>
        /// Specifies if RingCentral sells phone numbers of this country
        /// </summary>
        public bool? numberSelling { get; set; }

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        /// Specifies if free phone line for softphone is available for a country or not
        /// </summary>
        public bool? freeSoftphoneLine { get; set; }
    }
}