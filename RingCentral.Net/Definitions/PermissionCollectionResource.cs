namespace RingCentral
{
    public class PermissionCollectionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public PermissionResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public RNPPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public RNPNavigationInfo navigation { get; set; }
    }
}