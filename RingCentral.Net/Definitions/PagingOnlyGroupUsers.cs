namespace RingCentral
{
    public class PagingOnlyGroupUsers
    {
        /// <summary>
        ///     Link to a list of users allowed to page the Paging Only group
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of users allowed to page the Paging Only group
        /// </summary>
        public PagingGroupExtensionInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}