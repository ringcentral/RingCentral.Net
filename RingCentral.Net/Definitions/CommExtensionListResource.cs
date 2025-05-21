namespace RingCentral
{
    public class CommExtensionListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommReferencedExtensionResource[] referencedExtensions { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}