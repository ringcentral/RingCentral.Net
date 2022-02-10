namespace RingCentral
{
    /// <summary>
    ///     Request body for operation createFaxMessage
    /// </summary>
    public class CreateFaxMessageRequest
    {
        /// <summary>
        ///     Resolution of Fax
        ///     Enum: High, Low
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        ///     To Phone Number
        ///     Required
        /// </summary>
        public MessageStoreCalleeInfoRequest[] to { get; set; }

        /// <summary>
        ///     Timestamp to send fax at. If not specified (current or the past), the fax is sent immediately
        ///     Format: date-time
        /// </summary>
        public string sendTime { get; set; }

        /// <summary>
        ///     ISO Code. e.g UK
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        ///     Cover page identifier. If coverIndex is set to '0' (zero) cover page is not attached. For the list of available
        ///     cover page identifiers (1-13) please call the Fax Cover Pages method. If not specified, the default cover page is
        ///     attached (which is configured in 'Outbound Fax Settings')
        ///     Format: int32
        /// </summary>
        public long? coverIndex { get; set; }

        /// <summary>
        ///     Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        public string coverPageText { get; set; }

        /// <summary>
        ///     File to upload
        ///     Required
        ///     Format: binary
        /// </summary>
        public Attachment[] attachments { get; set; }
    }
}