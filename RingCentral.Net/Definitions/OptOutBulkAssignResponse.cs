namespace RingCentral
{
    /// <summary>
    ///     The results of adding opt-outs and opt-ins
    /// </summary>
    public class OptOutBulkAssignResponse
    {
        /// <summary>
        /// </summary>
        public BulkAssignOptOuts optOuts { get; set; }

        /// <summary>
        /// </summary>
        public BulkAssignOptIns optIns { get; set; }
    }
}