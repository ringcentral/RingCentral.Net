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
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
    }
}