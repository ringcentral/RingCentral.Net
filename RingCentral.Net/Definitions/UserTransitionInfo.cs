namespace RingCentral
{
    // For NotActivated extensions only. Welcome email settings
    public class UserTransitionInfo
    {
        /// <summary>
        /// Specifies if a welcome/activation email is sent to the existing users during account confirmation
        /// </summary>
        public bool? sendWelcomeEmailsToUsers;

        /// <summary>
        /// Specifies if a welcome/activation email is sent to the new users (within extension status changing from 'Unsassigned' to 'NotActivated/Disabled')
        /// </summary>
        public bool? sendWelcomeEmail;
    }
}