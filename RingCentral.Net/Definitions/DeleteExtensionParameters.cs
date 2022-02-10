namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteExtension
    /// </summary>
    public class DeleteExtensionParameters
    {
        /// <summary>
        /// </summary>
        public bool? savePhoneLines { get; set; }

        /// <summary>
        ///     Default: true
        /// </summary>
        public bool? savePhoneNumbers { get; set; }
    }
}