namespace RingCentral
{
    /// <summary>
    ///     The attribute declaration to indicate webinar session participant/invitee role
    /// </summary>
    public class RcwRoleAttributeModel
    {
        /// <summary>
        ///     The role of the webinar session participant/invitee.
        ///     See also: [Understanding Webinar
        ///     Roles](https://support.ringcentral.com/webinar/getting-started/understanding-ringcentral-webinar-roles.html)
        ///     Required
        ///     Example: Panelist
        ///     Enum: Panelist, CoHost, Host, Attendee
        /// </summary>
        public string role { get; set; }
    }
}