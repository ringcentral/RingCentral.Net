namespace RingCentral
{
    // CCRN (Contact Center Routing Number) provider. If not specified then the default value 'InContact/North America' is used, its ID is '1'
    public class ContactCenterProvider
    {
        /// <summary>
        /// Internal identifier of the provider
        /// </summary>
        public string id;

        /// <summary>
        /// Provider's name
        /// </summary>
        public string name;
    }
}