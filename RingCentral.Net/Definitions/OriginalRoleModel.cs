namespace RingCentral
{
    /// <summary>
    ///     Role assigned to participant when invite was sent or during join time (if an invite was not sent)
    /// </summary>
    public class OriginalRoleModel
    {
        /// <summary>
        ///     The role of the webinar session participant/invitee.
        ///     See also: [Understanding Webinar
        ///     Roles](https://support.ringcentral.com/webinar/getting-started/understanding-ringcentral-webinar-roles.html)
        ///     Required
        ///     Example: Panelist
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string originalRole { get; set; }
    }
}