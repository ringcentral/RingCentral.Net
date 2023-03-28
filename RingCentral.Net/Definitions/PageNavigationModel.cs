namespace RingCentral
{
    /// <summary>
    ///     Links to other pages of the current result set
    /// </summary>
    public class PageNavigationModel
    {
        /// <summary>
        /// </summary>
        public PageNavigationUri firstPage { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationUri nextPage { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationUri previousPage { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationUri lastPage { get; set; }
    }
}