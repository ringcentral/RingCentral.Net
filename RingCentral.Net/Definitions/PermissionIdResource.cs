namespace RingCentral
{
    public class PermissionIdResource
    {
        /// <summary>
        /// </summary>
        public string uri;

        /// <summary>
        /// </summary>
        public string id;

        /// <summary>
        /// Site compatibility flag set for permission
        /// Enum: Compatible, Incompatible, Independent
        /// </summary>
        public string siteCompatible;

        /// <summary>
        /// Specifies if the permission is editable on UI (if set to 'True') or not (if set to 'False')
        /// </summary>
        public bool? readOnly;

        /// <summary>
        /// Specifies if the permission can be assigned by the account administrator
        /// </summary>
        public bool? assignable;
    }
}