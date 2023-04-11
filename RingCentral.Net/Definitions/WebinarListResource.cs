namespace RingCentral
{
    public class WebinarListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public WcsWebinarResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}