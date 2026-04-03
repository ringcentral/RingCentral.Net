namespace RingCentral
{
    public class RecordingListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public RecordingItemModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}