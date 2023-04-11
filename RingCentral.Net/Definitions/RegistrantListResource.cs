namespace RingCentral
{
    public class RegistrantListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public RegistrantModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingForwardModel paging { get; set; }
    }
}