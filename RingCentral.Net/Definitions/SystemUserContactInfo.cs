namespace RingCentral
{
    /// <summary>
    ///     Personal contact information
    /// </summary>
    public class SystemUserContactInfo
    {
        /// <summary>
        ///     Given name
        ///     Required
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Family name
        ///     Required
        ///     Example: Smith
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Contact email
        ///     Required
        ///     Format: email
        ///     Example: john.smith@acme.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Required
        ///     Example: +16501234567
        /// </summary>
        public string contactPhone { get; set; }

        /// <summary>
        ///     Internal identifier of System user extension
        ///     Required
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Short number of an extension.
        ///     Actual max length depends on system length limit for extension.
        ///     Required
        ///     Example: 205
        /// </summary>
        public string extensionNumber { get; set; }
    }
}