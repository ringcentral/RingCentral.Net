namespace RingCentral
{
    /// <summary>
    ///     A list of SMS consent records
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