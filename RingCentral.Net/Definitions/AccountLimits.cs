namespace RingCentral
{
    public class AccountLimits
    {
        /// <summary>
        /// Max number of free softphone phone lines per user extension
        /// </summary>
        public long? freeSoftPhoneLinesPerExtension;

        /// <summary>
        /// Max number of participants in RingCentral meeting hosted by this account's user
        /// </summary>
        public long? meetingSize;

        /// <summary>
        /// Meetings recording cloud storage limitaion in Gb
        /// </summary>
        public long? cloudRecordingStorage;

        /// <summary>
        /// Max number of extensions which can be included in the list of users monitored for Presence
        /// </summary>
        public long? maxMonitoredExtensionsPerUser;

        /// <summary>
        /// Max length of extension numbers of an account; the supported value is up to 8 symbols, depends on account type
        /// Default: 5
        /// </summary>
        public long? maxExtensionNumberLength;

        /// <summary>
        /// Length of a site code
        /// </summary>
        public long? siteCodeLength;

        /// <summary>
        /// Length of a short extension number
        /// </summary>
        public long? shortExtensionNumberLength;
    }
}