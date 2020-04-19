namespace RingCentral
{
    public class AutomaticLocationUpdatesUserInfo
    {
        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        public string id;

        /// <summary>
        /// User name
        /// </summary>
        public string fullName;

        /// <summary>
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Specifies if Automatic Location Updates feature is enabled
        /// </summary>
        public bool? featureEnabled;

        /// <summary>
        /// User extension type
        /// Enum: User, Limited
        /// </summary>
        public string type;

        /// <summary>
        /// Site data
        /// </summary>
        public AutomaticLocationUpdatesSiteInfo site;

        /// <summary>
        /// Department name
        /// </summary>
        public string department;
    }
}