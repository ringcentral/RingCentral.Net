namespace RingCentral
{
    public class InviteeListResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public InviteeModel[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public RcwPagingModel paging { get; set; }
    }
}