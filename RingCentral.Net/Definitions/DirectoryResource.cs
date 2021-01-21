namespace RingCentral
{
    public class DirectoryResource
    {
        /// <summary>
        /// </summary>
        public CompanyContactsPagingInfo paging { get; set; }

        /// <summary>
        /// </summary>
        public ContactResource[] records { get; set; }
    }
}