namespace RingCentral
{
    public class GlipPostsList
    {
        /// <summary>
        /// List of posts
        /// Required
        /// </summary>
        public GlipPostInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}