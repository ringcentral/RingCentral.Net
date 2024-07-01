namespace RingCentral
{
    /// <summary>
    ///     Text message template information
    /// </summary>
    public class TemplateInfo
    {
        /// <summary>
        ///     Text of a message template. Maximum length is 1000 symbols (2-byte UTF-16 encoded)
        ///     Required
        /// </summary>
        public string text { get; set; }
    }
}