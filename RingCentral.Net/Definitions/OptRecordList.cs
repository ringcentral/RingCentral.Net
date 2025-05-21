namespace RingCentral
{
    /// <summary>
    ///     The list of records with opt statuses
    /// </summary>
    public class OptRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public SmsOptRecord[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}