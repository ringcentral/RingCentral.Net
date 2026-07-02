namespace RingCentral
{
    public class CallPartyReply
    {
        /// <summary>
        ///     Text to reply
        ///     Required
        /// </summary>
        public string replyWithText { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ReplyWithPattern replyWithPattern { get; set; }
    }
}