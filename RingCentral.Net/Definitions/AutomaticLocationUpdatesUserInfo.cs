namespace RingCentral
{
    public class AutomaticLocationUpdatesUserInfo
    {
        /// <summary>
        ///     Internal identifier of a device
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     User name
        /// </summary>
        public string fullName { get; set; }

        /// <summary>
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        ///     Specifies if Automatic Location Updates feature is enabled
        /// </summary>
        public bool? featureEnabled { get; set; }

        /// <summary>
        ///     User extension type
        ///     Enum: User, Limited
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site { get; set; }

        /// <summary>
        ///     Department name
        /// </summary>
        public string department { get; set; }
    }
}