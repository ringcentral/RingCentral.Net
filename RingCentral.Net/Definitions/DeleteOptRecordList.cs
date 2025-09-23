namespace RingCentral
{
    /// <summary>
    ///     A list of records for deleting SMS consents
    /// </summary>
    public class DeleteOptRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public MinimalSmsOptRecord[] records { get; set; }
    }
}