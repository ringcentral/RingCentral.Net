namespace RingCentral
{
    /// <summary>
    ///     A list of records for updating SMS consents
    /// </summary>
    public class UpdateOptRecordList
    {
        /// <summary>
        ///     Required
        /// </summary>
        public UpdateSmsOptRecord[] records { get; set; }
    }
}