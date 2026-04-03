namespace RingCentral
{
    public class BridgeJoinPstnPreferences
    {
        /// <summary>
        ///     Specifies whether to play 'Announce yourself' prompt
        ///     Default: true
        /// </summary>
        public bool? promptAnnouncement { get; set; }

        /// <summary>
        ///     Specifies whether to play 'There are X participants' prompt
        ///     Default: true
        /// </summary>
        public bool? promptParticipants { get; set; }
    }
}