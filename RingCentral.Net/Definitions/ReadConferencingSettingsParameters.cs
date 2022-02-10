namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readConferencingSettings
    /// </summary>
    public class ReadConferencingSettingsParameters
    {
        /// <summary>
        ///     Internal identifier of a country. If not specified, the response is returned for the brand country
        /// </summary>
        public string countryId { get; set; }
    }
}