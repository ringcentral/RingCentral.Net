namespace RingCentral
{
    public class AccountPhoneNumberInfoExtension
    {
        /// <summary>
        ///     Unique identifier of extension
        ///     Example: 1234567
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Short number of an extension.
        ///     Actual max length depends on system length limit for extension.
        ///     Example: 205
        /// </summary>
        public string extensionNumber { get; set; }
    }
}