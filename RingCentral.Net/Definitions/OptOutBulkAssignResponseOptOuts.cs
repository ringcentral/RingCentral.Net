namespace RingCentral
{
    public class OptOutBulkAssignResponseOptOuts
    {
        /// <summary>
        ///     Recipients' phone numbers which opt-outs were successfully added for.
        ///     Example: +15551237755
        /// </summary>
        public string[] successful { get; set; }

        /// <summary>
        ///     Recipients' phone numbers which opt-outs were failed to be added for. Plus, error messages
        ///     Example: [object Object]
        /// </summary>
        public OptOutBulkAssignFailedEntry[] failed { get; set; }
    }
}