namespace RingCentral
{
    public class CreateInternalTextMessageRequest
    {
        /// <summary>
        /// </summary>
        public PagerCallerInfoRequest from { get; set; }

        /// <summary>
        ///     Internal identifier of a message this message replies to
        /// </summary>
        public long? replyOn { get; set; }

        /// <summary>
        ///     Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes
        ///     in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
        ///     Required
        ///     Example: hello world
        /// </summary>
        public string text { get; set; }

        /// <summary>
        ///     Optional if replyOn parameter is specified. Receiver of a pager message.
        /// </summary>
        public PagerCallerInfoRequest[] to { get; set; }
    }
}