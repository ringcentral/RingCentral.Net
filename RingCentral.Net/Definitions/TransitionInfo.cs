namespace RingCentral
{
    public class TransitionInfo
    {
        /// <summary>
        ///     Specifies if a welcome/activation email is sent to the new users
        ///     (with the extension status transition from 'Unassigned' to 'NotActivated/Disabled')
        ///     Default: true
        /// </summary>
        public bool? sendWelcomeEmail { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionRegionalSettingRequest regionalSettings { get; set; }
    }
}