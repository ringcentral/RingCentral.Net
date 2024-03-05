namespace RingCentral
{
    public class ContentList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ContentModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}