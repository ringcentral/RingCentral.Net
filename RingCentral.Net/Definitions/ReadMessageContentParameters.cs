namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readMessageContent
    /// </summary>
    public class ReadMessageContentParameters
    {
        /// <summary>
        ///     Content disposition of a response
        ///     Default: Inline
        ///     Enum: Inline, Attachment
        /// </summary>
        public string contentDisposition { get; set; }
    }
}