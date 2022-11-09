namespace RingCentral
{
    public class TMPostsList
    {
        /// <summary>
        ///     List of posts
        ///     Required
        /// </summary>
        public TMPostInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public TMNavigationInfo navigation { get; set; }
    }
}