namespace RingCentral
{
    public class IdentitiesList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public IdentityModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}