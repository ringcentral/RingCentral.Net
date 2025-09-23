namespace RingCentral
{
    public class SimpleSettings
    {
        /// <summary>
        ///     Email notification flag
        /// </summary>
        public bool? notifyByEmail { get; set; }

        /// <summary>
        ///     SMS notification flag
        /// </summary>
        public bool? notifyBySms { get; set; }

        /// <summary>
        ///     The parameter contains the list of phone Numbers which should be used for SMS notifications sending (if advanced
        ///     mode enabled)
        /// </summary>
        public string[] advancedSmsPhoneNumbers { get; set; }
    }
}