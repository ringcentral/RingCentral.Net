namespace RingCentral
{
    /// <summary>
    ///     The list of records to update opt statuses of phone numbers
    /// </summary>
    public class UpdateOptRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public UpdateSmsOptRecord[] records { get; set; }
    }
}