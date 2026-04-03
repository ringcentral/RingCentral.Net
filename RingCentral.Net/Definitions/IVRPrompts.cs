namespace RingCentral
{
    public class IvrPrompts
    {
        /// <summary>
        ///     Link to prompts library resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of Prompts
        /// </summary>
        public PromptInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}