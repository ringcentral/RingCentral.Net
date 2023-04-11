namespace RingCentral
{
    public class WirelessPointsList
    {
        /// <summary>
        ///     Link to a wireless points resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of wireless points with assigned emergency addresses
        /// </summary>
        public WirelessPointInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}