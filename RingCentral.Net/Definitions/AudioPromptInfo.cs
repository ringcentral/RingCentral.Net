namespace RingCentral
{
    /// <summary>
    ///     For 'Audio' mode only. Prompt media reference
    /// </summary>
    public class AudioPromptInfo
    {
        /// <summary>
        ///     Link to a prompt audio file
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     Internal identifier of a prompt
        /// </summary>
        public string id { get; set; }
    }
}