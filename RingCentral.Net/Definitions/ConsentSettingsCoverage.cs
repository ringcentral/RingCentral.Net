namespace RingCentral
{
    /// <summary>
    /// Consent coverage setting for the TCR campaign.
    /// </summary>
    public class ConsentSettingsCoverage
    {
        /// <summary>
        ///     Coverage type.
        ///     Enum: PhoneNumber, Account, Conversational, Informational, Promotional
        /// </summary>
        public string optIn { get; set; }

        /// <summary>
        ///     Coverage type.
        ///     Enum: PhoneNumber, Account, Conversational, Informational, Promotional
        /// </summary>
        public string optOut { get; set; }
    }
}