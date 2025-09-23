namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation checkUserPermission
    /// </summary>
    public class CheckUserPermissionParameters
    {
        /// <summary>
        ///     The ID of the permission to be checked
        /// </summary>
        public string permissionId { get; set; }

        /// <summary>
        ///     The target extension ID (that can be an "object" of certain permissions)
        /// </summary>
        public string targetExtensionId { get; set; }
    }
}