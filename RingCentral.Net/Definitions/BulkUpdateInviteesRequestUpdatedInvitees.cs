namespace RingCentral
{
    public class BulkUpdateInviteesRequestUpdatedInvitees
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
        ///     User's contact email
        ///     Format: email
        ///     Example: john.doe@example.com
        /// </summary>
        public string email { get; set; }

        /// <summary>
        ///     Job title
        ///     Example: Product Manager
        /// </summary>
        public string jobTitle { get; set; }

        /// <summary>
        ///     The role of the webinar session participant/invitee.
        ///     See also: [Understanding Webinar
        ///     Roles](https://support.ringcentral.com/webinar/getting-started/understanding-ringcentral-webinar-roles.html)
        ///     Example: Panelist
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string role { get; set; }

        /// <summary>
        ///     The type of the webinar invitee
        ///     Default: User
        ///     Enum: User, Room
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Indicates if invite/cancellation emails have to be sent to this invitee.
        ///     For "Host" it cannot be set to false.
        ///     If it is true it can't be changed back to false.
        ///     Default: true
        /// </summary>
        public bool? sendInvite { get; set; }
    }
}