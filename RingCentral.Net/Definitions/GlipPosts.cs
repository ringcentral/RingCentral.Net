namespace RingCentral
{
    public class GlipPosts
    {
        /// <summary>
        ///     List of posts
        ///     Required
        /// </summary>
        public GlipPostInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public GlipNavigationInfo navigation { get; set; }
    }
}