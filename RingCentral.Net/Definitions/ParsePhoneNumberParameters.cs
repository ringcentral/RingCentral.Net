namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation parsePhoneNumber
    /// </summary>
    public class ParsePhoneNumberParameters
    {
        /// <summary>
        ///     ISO 3166 alpha2 code of the home country to be used if it is impossible to determine country from the number
        ///     itself.
        ///     By default, this parameter is preset to the current user's home country or brand country if the user is undefined
        ///     Example: US
        /// </summary>
        public string homeCountry { get; set; }

        /// <summary>
        ///     The default value is `false`. If `true`, the numbers that are
        ///     closer to the home country are given higher priority
        /// </summary>
        public bool? nationalAsPriority { get; set; }
    }
}