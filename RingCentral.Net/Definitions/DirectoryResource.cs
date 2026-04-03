namespace RingCentral
{
    public class DirectoryResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ContactResource[] records { get; set; }
    }
}