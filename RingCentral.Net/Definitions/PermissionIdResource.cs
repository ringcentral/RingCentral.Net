namespace RingCentral
{
    public class PermissionIdResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Site compatibility flag set for permission
        ///     Enum: Compatible, Incompatible, Independent
        /// </summary>
        public string siteCompatible { get; set; }

        /// <summary>
        ///     Specifies if the permission is editable on UI (if set to `true`) or not (if set to `false`)
        /// </summary>
        public bool? readOnly { get; set; }

        /// <summary>
        ///     Specifies if the permission can be assigned by the account administrator
        /// </summary>
        public bool? assignable { get; set; }

        /// <summary>
        /// </summary>
        public PermissionsCapabilities permissionsCapabilities { get; set; }
    }
}