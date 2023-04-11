namespace RingCentral
{
    public class WcsSessionGeneratedModel
    {
        /// <summary>
        ///     The RCV bridge id
        ///     Example: 839874770
        /// </summary>
        public string videoBridgeId { get; set; }

        /// <summary>
        ///     The RCV bridge password. Returned only if requested by Host/Co-host/Panelist and a password for the bridge is set.
        ///     Format: password
        ///     Example: abc123
        /// </summary>
        public string videoBridgePassword { get; set; }

        /// <summary>
        ///     The RCV bridge PSTN password. Returned only if requested by Host/Co-host/Panelist and a PSTN password for the
        ///     bridge is set.
        ///     Format: password
        ///     Example: abc123
        /// </summary>
        public string videoBridgePstnPassword { get; set; }

        /// <summary>
        ///     The URI for attendees to join the Webinar (if it is a public webinar)
        ///     Format: uri
        ///     Example: https://v.ringcentral.com/w/a/join/iuyef77fsj473wn10ashjfk34
        /// </summary>
        public string attendeeJoinUri { get; set; }

        /// <summary>
        ///     Calculated attribute indicating if there are any unsent/deferred invites to session participants
        /// </summary>
        public bool? hasUnsentInvites { get; set; }
    }
}