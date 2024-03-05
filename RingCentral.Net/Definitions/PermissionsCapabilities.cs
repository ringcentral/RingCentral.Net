namespace RingCentral
{
    /// <summary>
    ///     Advanced permissions capabilities. Returned if `advancedPermissions` query parameter is set to `true`.
    /// </summary>
    public class PermissionsCapabilities
    {
        /// <summary>
        ///     Specifies whether the user is enabled with the listed permission or not
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Specifies if the user can manage the listed permission and is allowed to enable it on other users
        /// </summary>
        public bool? manageEnabled { get; set; }

        /// <summary>
        ///     Specifies if the users who were enabled with the listed permission can grant it further to other users
        /// </summary>
        public bool? grantEnabled { get; set; }
    }
}