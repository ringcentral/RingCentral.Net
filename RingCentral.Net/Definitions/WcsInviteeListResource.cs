namespace RingCentral
{
    public class WcsInviteeListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public InviteeResource[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}