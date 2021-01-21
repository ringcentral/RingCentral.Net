namespace RingCentral
{
    public class CreateFaxMessageRequest
    {
        /// <summary>
        /// Resolution of Fax
        /// Enum: High, Low
        /// </summary>
        public string faxResolution { get; set; }

        /// <summary>
        /// To Phone Number
        /// </summary>
        public MessageStoreCalleeInfoRequest[] to { get; set; }

        /// <summary>
        /// Timestamp to send fax at. If not specified (current or the past), the fax is sent immediately
        /// </summary>
        public string sendTime { get; set; }

        /// <summary>
        /// ISO Code. e.g UK
        /// </summary>
        public string isoCode { get; set; }

        /// <summary>
        /// Cover page identifier. For the list of available cover page identifiers please call the method Fax Cover Pages. If not specified, the default cover page which is configured in 'Outbound Fax Settings' is attached
        /// </summary>
        public long? coverIndex { get; set; }

        /// <summary>
        /// Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
        /// </summary>
        public string coverPageText { get; set; }

        /// <summary>
        /// File to upload
        /// </summary>
        public Attachment[] attachments { get; set; }
    }
}