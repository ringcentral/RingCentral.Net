namespace RingCentral
{
    /// <summary>
    /// A list of SMS consent records
    /// </summary>
    public class ConsentHistoryRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public SmsOptHistoryRecord[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public NonEnumeratedPagingModel paging { get; set; }
    }
}