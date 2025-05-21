namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readUserRole
    /// </summary>
    public class ReadUserRoleParameters
    {
        /// <summary>
        ///     Specifies whether to return advanced permissions capabilities within `permissionsCapabilities` resource.
        ///     The default value is false
        /// </summary>
        public bool? advancedPermissions { get; set; }
    }
}