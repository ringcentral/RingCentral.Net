namespace RingCentral
{
    public class ScheduleMeetingResponse
    {
        /// <summary>
        /// </summary>
        public bool? startHostVideo { get; set; }

        /// <summary>
        /// </summary>
        public bool? startParticipantVideo { get; set; }

        /// <summary>
        /// </summary>
        public bool? audioOptions { get; set; }

        /// <summary>
        /// </summary>
        public bool? allowJoinBeforeHost { get; set; }

        /// <summary>
        /// </summary>
        public bool? requirePasswordForSchedulingNewMeetings { get; set; }

        /// <summary>
        /// </summary>
        public bool? requirePasswordForInstantMeetings { get; set; }

        /// <summary>
        /// </summary>
        public bool? requirePasswordForPmiMeetings { get; set; }

        /// <summary>
        /// </summary>
        public bool? enforceLogin { get; set; }
    }
}