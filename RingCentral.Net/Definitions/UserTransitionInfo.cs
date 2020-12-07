namespace RingCentral
{
    // For NotActivated extensions only. Welcome email settings
    public class UserTransitionInfo
    {
        /// <summary>
        /// Specifies if an activation email is automatically sent to new users (Not Activated extensions) or not
        /// </summary>
        public bool? sendWelcomeEmailsToUsers;

        /// <summary>
        /// Supported for account confirmation. Specifies whether welcome email is sent
        /// </summary>
        public bool? sendWelcomeEmail;
    }
}