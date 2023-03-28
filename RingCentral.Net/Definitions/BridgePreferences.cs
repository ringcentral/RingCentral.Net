namespace RingCentral
{
    public class BridgePreferences
    {
        /// <summary>
        /// </summary>
        public BridgeJoinPreferences join { get; set; }

        /// <summary>
        ///     Specifies enter and exit tones mode.
        ///     1) On - Enter and exit tones switched on.
        ///     2) Off - Enter and exit tones switched off.
        ///     3) ExitOnly - Only exit tones switched on.
        ///     4) EnterOnly - Only enter tones switched on.
        ///     Default: Off
        ///     Enum: On, Off, ExitOnly, EnterOnly
        /// </summary>
        public string playTones { get; set; }

        /// <summary>
        ///     Specifies whether to play music on hold when alone
        ///     Default: true
        /// </summary>
        public bool? musicOnHold { get; set; }

        /// <summary>
        ///     Specifies if participants can join to a meeting before host.
        ///     Default value depends on the bridge type:
        ///     - default bridge (PMI) -> false
        ///     - other types -> true
        ///     Example: true
        /// </summary>
        public bool? joinBeforeHost { get; set; }

        /// <summary>
        ///     Specifies if screen sharing is allowed
        ///     Default: true
        /// </summary>
        public bool? screenSharing { get; set; }

        /// <summary>
        ///     Controls whether recordings are enabled automatically or by user decision
        ///     Example: User
        ///     Enum: Auto, ForceAuto, User
        /// </summary>
        public string recordingsMode { get; set; }

        /// <summary>
        ///     Controls whether transcriptions are enabled automatically or by user decision
        ///     Example: User
        ///     Enum: Auto, ForceAuto, User
        /// </summary>
        public string transcriptionsMode { get; set; }

        /// <summary>
        /// </summary>
        public RecordingsPreferences recordings { get; set; }

        /// <summary>
        ///     Controls whether participants can start and pause transcription
        ///     Default: true
        /// </summary>
        public bool? allowEveryoneTranscribeMeetings { get; set; }
    }
}