namespace RingCentral
{
    /// <summary>
    ///     CCRN (Contact Center Routing Number) provider. If not specified
    ///     then the default value 'InContact/North America' is used, its ID is '1'
    /// </summary>
    public class ContactCenterProvider
    {
        /// <summary>
        ///     Internal identifier of the provider
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Provider's name
        /// </summary>
        public string name { get; set; }
    }
}