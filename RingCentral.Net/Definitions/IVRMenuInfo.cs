namespace RingCentral
{
    public class IVRMenuInfo
    {
        /// <summary>
        ///     Internal identifier of an IVR Menu extension
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to an IVR Menu extension resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     First name of an IVR Menu user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Number of an IVR Menu extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public IVRMenuSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public IVRMenuPromptInfo prompt { get; set; }

        /// <summary>
        ///     Keys handling settings
        /// </summary>
        public IVRMenuActionsInfo[] actions { get; set; }
    }
}