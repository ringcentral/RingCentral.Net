namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteExtension
    /// </summary>
    public class DeleteExtensionParameters
    {
        /// <summary>
        ///     If `true`, the digital lines from the deleted extension are saved in inventory.
        /// </summary>
        public bool? savePhoneLines { get; set; }

        /// <summary>
        ///     If `true`, the phone numbers from the deleted extension are saved in inventory.
        ///     Default: true
        /// </summary>
        public bool? savePhoneNumbers { get; set; }
    }
}