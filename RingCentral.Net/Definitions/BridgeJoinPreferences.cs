namespace RingCentral
{
    public class BridgeJoinPreferences
    {
        /// <summary>
        ///     Specifies if audio is muted for meeting participants (in the preset after joining)
        /// </summary>
        public bool? audioMuted { get; set; }

        /// <summary>
        ///     Specifies if video is muted for meeting participants (in the preset after joining)
        /// </summary>
        public bool? videoMuted { get; set; }

        /// <summary>
        ///     Specifies rules for the waiting room before the host starts the meeting.
        ///     1) Nobody - No waiting room. Participants are not waiting for meeting start.
        ///     2) Everybody - All participants are waiting for meeting start.
        ///     3) GuestsOnly - Only unauthenticated participants (guests) are waiting for meeting start.
        ///     4) OtherAccount - Only participants who have other account are waiting for meeting start.
        ///     Default value depends on the bridge type:
        ///     - PMI -> OtherAccount
        ///     - Instant, Scheduled -> Nobody
        ///     Example: Nobody
        ///     Enum: Nobody, Everybody, GuestsOnly, OtherAccount
        /// </summary>
        public string waitingRoomRequired { get; set; }

        /// <summary>
        /// </summary>
        public BridgeJoinPstnPreferences pstn { get; set; }
    }
}