namespace RingCentral
{
    public class ExtensionPermissionsResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public Permission admin { get; set; }

        /// <summary>
        /// </summary>
        public Permission internationalCalling { get; set; }

        /// <summary>
        /// </summary>
        public Permission freeSoftPhoneDigitalLine { get; set; }
    }
}