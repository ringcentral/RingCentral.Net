namespace RingCentral
{
    public class AutomaticRecordingResource
    {
        /// <summary>
        /// Flag for controling Automatic Call Recording settings
        /// </summary>
        public bool? enabled;

        /// <summary>
        /// Flag for controlling 'Play Call Recording Announcement for Outbound Calls' settings
        /// </summary>
        public bool? outboundCallTones;

        /// <summary>
        /// Flag for controlling 'Play periodic tones for outbound calls' settings
        /// </summary>
        public bool? outboundCallAnnouncement;

        /// <summary>
        /// Flag for controlling 'Allow mute in auto call recording' settings
        /// </summary>
        public bool? allowMute;

        /// <summary>
        /// Total amount of extension that are used in call recordings
        /// </summary>
        public long? extensionCount;
    }
}