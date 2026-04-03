namespace RingCentral
{
    public class ExtensionWithRolesResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// </summary>
        public AssignedRoleResource[] roles { get; set; }
    }
}