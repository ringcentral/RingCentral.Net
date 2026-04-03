namespace RingCentral
{
    /// <summary>
    /// Appearance phone numbers information. Supported only for Delegated Lines Group extensions
    /// </summary>
    public class AppearancesInfo
    {
        /// <summary>
        ///     Appearance phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Appearance number. The value range is from 1 to 8
        ///     Format: int32
        /// </summary>
        public long? appearanceNumber { get; set; }

        /// <summary>
        ///     Appearance line status. The two possible values: 'Seized' - the phone line is busy; 'Released' - the phone line is open
        ///     Enum: Seized, Released
        /// </summary>
        public string lineStatus { get; set; }
    }
}