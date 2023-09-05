namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readIVRPromptContent
    /// </summary>
    public class ReadIVRPromptContentParameters
    {
        /// <summary>
        ///     Whether the content is expected to be displayed in the browser, or downloaded and saved locally
        ///     Enum: Inline, Attachment
        /// </summary>
        public string contentDisposition { get; set; }

        /// <summary>
        ///     The default filename of the file to be downloaded
        /// </summary>
        public string contentDispositionFilename { get; set; }
    }
}