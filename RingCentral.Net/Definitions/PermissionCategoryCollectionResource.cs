namespace RingCentral
{
    public class PermissionCategoryCollectionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public PermissionCategoryResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public RNPPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public RNPNavigationInfo navigation { get; set; }
    }
}