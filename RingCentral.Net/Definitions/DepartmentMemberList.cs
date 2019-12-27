namespace RingCentral
{
    public class DepartmentMemberList
    {
        /// <summary>
        /// Link to the list of department members
        /// </summary>
        public string uri;

        /// <summary>
        /// List of department members extensions
        /// </summary>
        public ExtensionInfo[] records;

        /// <summary>
        /// Information on navigation
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Information on paging
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}