using Newtonsoft.Json;

namespace RingCentral
{
    public class AccountLimits : Serializable
    {
        // Max number of free softphone phone lines per user extension
        public int? freeSoftPhoneLinesPerExtension;
        // Max number of participants in RingCentral meeting hosted by this account's user
        public int? meetingSize;
        // Meetings recording cloud storage limitaion in Gb
        public int? cloudRecordingStorage;
        // Max number of extensions which can be included in the list of users monitored for Presence
        public int? maxMonitoredExtensionsPerUser;
        // Max length of extension numbers of an account; depends on account type
        public int? maxExtensionNumberLength;
        // Length of a site code
        public int? siteCodeLength;
        // Length of a short extension number
        public int? shortExtensionNumberLength;
    }
}