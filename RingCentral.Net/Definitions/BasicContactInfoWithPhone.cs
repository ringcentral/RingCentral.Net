namespace RingCentral
{
    /// <summary>
    ///     Personal contact information
    /// </summary>
    public class BasicContactInfoWithPhone
    {
        /// <summary>
        ///     Given name
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Family name
        ///     Example: Smith
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     Contact email
        ///     Format: email
        ///     Example: john.smith@acme.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string contactPhone { get; set; }
    }
}