namespace RingCentral
{
    public class RegistrantListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public RegistrantModelWithQuestionnaire[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingForwardModel paging { get; set; }
    }
}