namespace RingCentral
{
    public class CallQueueMember
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string id;

        /// <summary>
        /// Extension full name
        /// </summary>
        public string name;

        /// <summary>
        /// Extension number
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Extension site
        /// </summary>
        public SiteResource site;
    }
}