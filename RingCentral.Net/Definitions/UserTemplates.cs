namespace RingCentral
{
    public class UserTemplates
    {
        /// <summary>
        /// Link to user templates resource
        /// </summary>
        public string uri;

        /// <summary>
        /// List of user templates
        /// Required
        /// </summary>
        public TemplateInfo[] records;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningNavigationInfo navigation;

        /// <summary>
        /// Required
        /// </summary>
        public ProvisioningPagingInfo paging;
    }
}