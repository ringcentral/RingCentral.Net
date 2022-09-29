namespace RingCentral
{
    public class DirectoryResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public PagingInfo paging { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ContactResource[] records { get; set; }
    }
}