namespace RingCentral
{
    /// <summary>
    ///     The internal IDs of RC-authenticated users.
    /// </summary>
    public class ParticipantExtendedModel
    {
        /// <summary>
        ///     Internal object ID
        ///     Example: 78654321
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     First (given) name
        ///     Example: John
        /// </summary>
        public string firstName { get; set; }

        /// <summary>
        ///     Last (family) name
        ///     Example: Doe
        /// </summary>
        public string lastName { get; set; }

        /// <summary>
        ///     The role of the webinar session participant/invitee.
        ///     See also: [Understanding Webinar
        ///     Roles](https://support.ringcentral.com/webinar/getting-started/understanding-ringcentral-webinar-roles.html)
        ///     Required
        ///     Example: Panelist
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string role { get; set; }

        /// <summary>
        ///     The role of the webinar session participant/invitee.
        ///     See also: [Understanding Webinar
        ///     Roles](https://support.ringcentral.com/webinar/getting-started/understanding-ringcentral-webinar-roles.html)
        ///     Required
        ///     Example: Panelist
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string originalRole { get; set; }

        /// <summary>
        /// </summary>
        public RcwDomainUserModel linkedUser { get; set; }

        /// <summary>
        ///     A token to access avatar image from CDN. Available only for authenticated panel members and attendees
        ///     Example: wedyugwied8wud98u90i329silqdjalidj
        /// </summary>
        public string avatarToken { get; set; }

        /// <summary>
        ///     The type of the participant specified in invite or determined at join time
        ///     Required
        ///     Default: User
        ///     Enum: User, Room
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     User's contact email
        ///     Format: email
        ///     Example: john.doe@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Boolean to indicate if the participant was blocked from Q&A
        ///     Example: true
        /// </summary>
        public bool? qnaBlocked { get; set; }

        /// <summary>
        ///     The time (earliest) when this participant joined the session
        ///     Format: date-time
        /// </summary>
        public string joinTime { get; set; }

        /// <summary>
        ///     The time (latest) when this participant left the session
        ///     Format: date-time
        /// </summary>
        public string leaveTime { get; set; }

        /// <summary>
        ///     Indicates if this participant was ejected from the webinar
        /// </summary>
        public bool? wasEjected { get; set; }

        /// <summary>
        ///     For invited participants - Invitee ID (matches Configuration API Invitee IDs)
        /// </summary>
        public string inviteeId { get; set; }

        /// <summary>
        ///     Registrant ID
        ///     Example: 12345678
        /// </summary>
        public string registrantId { get; set; }

        /// <summary>
        ///     The hash string which is unique for each unique user
        ///     Example: qzR4wNbddziRil7i033ELlb3KXrJDsw8mOyj970J+so=
        /// </summary>
        public string uniqueUserHash { get; set; }
    }
}