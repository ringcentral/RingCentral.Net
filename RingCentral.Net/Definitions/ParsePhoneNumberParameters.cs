namespace RingCentral
{
    // Query parameters for operation parsePhoneNumber
    public class ParsePhoneNumberParameters
    {
        /// <summary>
        ///     Internal identifier of a home country. The default value is ISO code (ISO 3166) of the user's home country or brand
        ///     country, if the user is undefined
        /// </summary>
        public string homeCountry { get; set; }

        /// <summary>
        ///     The default value is 'False'. If 'True', the numbers that are closer to the home country are given higher priority
        /// </summary>
        public bool? nationalAsPriority { get; set; }
    }
}