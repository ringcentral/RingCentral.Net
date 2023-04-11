namespace RingCentral
{
    /// <summary>
    ///     The internal IDs of RC-authenticated users.
    /// </summary>
    public class InviteeModel
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
        ///     A token to access avatar image from CDN. Available only for authenticated panelists
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
        ///     Indicates if invite/cancellation emails was sent to this invitee.
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? sendInvite { get; set; }

        /// <summary>
        ///     Indicates that this invitee joined the session
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? joined { get; set; }
    }
}