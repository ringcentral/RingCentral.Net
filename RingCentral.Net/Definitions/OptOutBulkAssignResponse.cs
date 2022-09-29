namespace RingCentral
{
    /// <summary>
    ///     The results of adding opt-outs and opt-ins
    /// </summary>
    public class OptOutBulkAssignResponse
    {
        /// <summary>
        ///     Contains successful and failed opt-ins
        /// </summary>
        public OptOutBulkAssignResponseOptIns optIns { get; set; }

        /// <summary>
        ///     Contains successful and failed opt-outs
        /// </summary>
        public OptOutBulkAssignResponseOptOuts optOuts { get; set; }
    }
}