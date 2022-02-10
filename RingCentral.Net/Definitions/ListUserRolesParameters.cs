namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listUserRoles
    /// </summary>
    public class ListUserRolesParameters
    {
        /// <summary>
        ///     Specifies whether to return custom or predefined only roles. If not specified, all roles are returned
        /// </summary>
        public bool? custom { get; set; }

        /// <summary>
        ///     Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        ///     Default: 100
        /// </summary>
        public string perPage { get; set; }
    }
}