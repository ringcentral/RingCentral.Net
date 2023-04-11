namespace RingCentral
{
    public class ParticipantListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public ParticipantExtendedModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}