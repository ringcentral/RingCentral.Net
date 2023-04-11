namespace RingCentral
{
    /// <summary>
    ///     The internal IDs of RC-authenticated users.
    /// </summary>
    public class ParticipantReducedModel
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
    }
}