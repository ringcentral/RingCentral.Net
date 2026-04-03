namespace RingCentral
{
    public class CommStatesResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommStateResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}