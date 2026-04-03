namespace RingCentral
{
    public class CommForwardingTargetsResource
    {
        /// <summary>
        ///     Required
        /// </summary>
        public CommForwardingTargetsResourceRecords[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}