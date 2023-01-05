namespace RingCentral
{
    /// <summary>
    ///     Please note that legacy 'Department' extension type corresponds to
    ///     'Call Queue' extensions in modern RingCentral product terminology
    /// </summary>
    public class DepartmentMemberList
    {
        /// <summary>
        ///     Canonical URL of the resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of call queue member extensions
        /// </summary>
        public ExtensionInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public ProvisioningPagingInfo paging { get; set; }
    }
}