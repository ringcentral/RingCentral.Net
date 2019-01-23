namespace RingCentral
{
    public class AutomaticRecordingResource : Serializable
    {
        // Flag for controling Automatic Call Recording settings
        public bool? enabled;

        // Flag for controlling 'Play Call Recording Announcement for Outbound Calls' settings
        public bool? outboundCallTones;

        // Flag for controlling 'Play periodic tones for outbound calls' settings
        public bool? outboundCallAnnouncement;

        // Flag for controlling 'Allow mute in auto call recording' settings
        public bool? allowMute;

        // Total amount of extension that are used in call recordings
        public long? extensionCount;
    }
}