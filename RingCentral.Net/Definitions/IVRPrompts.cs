namespace RingCentral
{
    public class IvrPrompts
    {
        /// <summary>
        ///     Link to prompts library resource
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of Prompts
        /// </summary>
        public PromptInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public NavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPaging paging { get; set; }
    }
}