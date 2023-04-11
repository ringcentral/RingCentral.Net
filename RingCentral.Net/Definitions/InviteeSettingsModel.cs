namespace RingCentral
{
    public class InviteeSettingsModel
    {
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