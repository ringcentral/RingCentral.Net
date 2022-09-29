namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readA2PSMSOptOuts
    /// </summary>
    public class ReadA2PSMSOptOutsParameters
    {
        /// <summary>
        ///     The sender's phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for filtering messages.
        ///     The asterisk value "*" means any number in `from` field
        ///     Example: 15551234455
        /// </summary>
        public string from { get; set; }

        /// <summary>
        ///     The receiver's phone number (`to` field) in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format for
        ///     filtering messages
        ///     Example: 15551237755
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     The status (opted out, opted in, or both) to be used as the filter
        ///     Example: optout
        ///     Default: optout
        ///     Enum: optout, optin, all
        /// </summary>
        public string status { get; set; }

        /// <summary>
        ///     The page token of the page to be retrieved
        ///     Example: pgt1
        /// </summary>
        public string pageToken { get; set; }

        /// <summary>
        ///     The number of records to be returned for the page
        ///     Format: int32
        ///     Example: 5
        ///     Default: 1000
        /// </summary>
        public long? perPage { get; set; }
    }
}