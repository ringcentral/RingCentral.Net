namespace RingCentral
{
    public class SitesList
    {
        /// <summary>
        ///     Link to a sites resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// </summary>
        public SiteInfo[] records { get; set; }
    }
}