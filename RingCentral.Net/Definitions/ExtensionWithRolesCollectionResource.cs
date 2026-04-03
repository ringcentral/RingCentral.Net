namespace RingCentral
{
    public class ExtensionWithRolesCollectionResource
    {
        /// <summary>
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionWithRolesResource[] records { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }
    }
}