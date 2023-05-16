namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createFaxMessage
    /// </summary>
    public class CreateFaxMessageRequest
    {
        /// <summary>
        ///     Fax only. Resolution of a fax message. 'High' for black and
        ///     white image scanned at 200 dpi, 'Low' for black and white image scanned
        ///     at 100 dpi
        ///     Enum: High, Low
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        ///     Recipient's phone number(s)
        ///     Required
        /// </summary>
        public FaxReceiver[] to { get; set; }

        /// <summary>
        ///     Timestamp to send a fax at. If not specified, current or the past
        ///     a fax message is sent immediately
        ///     Format: date-time
        /// </summary>
        public string sendTime { get; set; }

        /// <summary>
        ///     ISO Code. e.g UK
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Cover page identifier. If `coverIndex` is set to '0' (zero) a cover page
        ///     is not attached. For a list of available cover page identifiers (1-13)
        ///     please call the Fax Cover Pages method. If not specified, the default cover
        ///     page is attached (which is configured in 'Outbound Fax Settings')
        ///     Format: int32
        /// </summary>
        public long? coverIndex { get; set; }

        /// <summary>
        ///     Cover page text, entered by a fax sender and printed
        ///     on a cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        public string coverPageText { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public Attachment[] attachments { get; set; }
    }
}