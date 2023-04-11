namespace RingCentral
{
    public class SessionGlobalListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public SessionGlobalResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}