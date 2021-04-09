namespace RingCentral
{
    public class IVRPrompts
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
        public CallHandlingNavigationInfo navigation { get; set; }

        /// <summary>
        /// </summary>
        public CallHandlingPagingInfo paging { get; set; }
    }
}