using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class CreateInternalTextMessageRequest : Serializable
    {
        // Sender of a pager message.
        public PagerCallerInfoRequest from; // Required
        // Internal identifier of a message this message replies to
        public long? replyOn;
        // Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
        public string text; // Required
        // Optional if replyOn parameter is specified. Receiver of a pager message.
        public PagerCallerInfoRequest[] to;
    }
}