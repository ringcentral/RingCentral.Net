namespace RingCentral
{
    /// <summary>
    ///     The list of records to delete opt statuses of phone numbers
    /// </summary>
    public class DeleteOptRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MinimalSmsOptRecord[] records { get; set; }
    }
}