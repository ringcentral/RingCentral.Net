namespace RingCentral
{
    public class ThreadNoteList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ThreadNoteModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}