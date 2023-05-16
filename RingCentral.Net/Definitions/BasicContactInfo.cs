namespace RingCentral
{
    /// <summary>
    ///     Personal contact information
    /// </summary>
    public class BasicContactInfo
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
    }
}