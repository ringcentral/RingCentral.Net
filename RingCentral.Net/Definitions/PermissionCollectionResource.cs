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
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
    }
}