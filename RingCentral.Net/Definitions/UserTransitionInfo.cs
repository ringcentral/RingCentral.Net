namespace RingCentral
{
    /// <summary>
    ///     For NotActivated extensions only. Welcome email settings
    /// </summary>
    public class UserTransitionInfo
    {
        /// <summary>
        ///     Specifies if a welcome/activation email is sent to the existing
        ///     users during account confirmation
        /// </summary>
        public bool? sendWelcomeEmailsToUsers { get; set; }

        /// <summary>
        ///     Specifies if a welcome/activation email is sent to the new users (within extension status changing from
        ///     'Unassigned' to 'NotActivated/Disabled')
        /// </summary>
        public bool? sendWelcomeEmail { get; set; }
    }
}