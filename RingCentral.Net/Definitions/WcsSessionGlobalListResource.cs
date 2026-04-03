namespace RingCentral
{
    public class WcsSessionGlobalListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public SessionGlobalListEntry[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}