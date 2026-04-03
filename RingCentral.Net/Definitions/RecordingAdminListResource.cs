namespace RingCentral
{
    public class RecordingAdminListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public RecordingAdminModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}