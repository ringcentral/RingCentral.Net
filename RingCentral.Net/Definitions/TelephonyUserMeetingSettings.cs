namespace RingCentral
{
    public class TelephonyUserMeetingSettings
    {
        /// <summary>
        /// ThirdParty audio option
        /// </summary>
        public bool? thirdPartyAudio { get; set; }

        /// <summary>
        /// Users can join the meeting using the existing 3rd party audio configuration
        /// </summary>
        public bool? audioConferenceInfo { get; set; }
    }
}