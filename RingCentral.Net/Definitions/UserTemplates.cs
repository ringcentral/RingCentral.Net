namespace RingCentral
{
    public class UserTemplates
    {
        /// <summary>
        ///     Link to user templates resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of user templates
        ///     Required
        /// </summary>
        public TemplateInfo[] records { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}