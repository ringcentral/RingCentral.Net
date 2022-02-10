namespace RingCentral
{
    /// <summary>
    ///     Consists of `from` field and `optOuts` and `optIns` lists. Both `optOuts` and `optIns` can be empty but not
    ///     simultaneously - at least one of the lists must be entered."
    /// </summary>
    public class OptOutBulkAssignRequest
    {
        /// <summary>
        ///     The phone number of a sender which the recipients should be opted out from or opted in to
        ///     Required
        ///     Example: 15551234455
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     The list of phone numbers to be opted out
        ///     Example: ["15551237755", "15551237756"]
        /// </summary>
        public string[] optOuts { get; set; }

        /// <summary>
        ///     The list of phone numbers to be opted in
        ///     Example: ["15551237799", "15551237798"]
        /// </summary>
        public string[] optIns { get; set; }
    }
}