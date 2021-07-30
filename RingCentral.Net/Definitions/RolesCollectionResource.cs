namespace RingCentral
{
    public class RolesCollectionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public RoleResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public RNPPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public RNPNavigationInfo navigation { get; set; }
    }
}