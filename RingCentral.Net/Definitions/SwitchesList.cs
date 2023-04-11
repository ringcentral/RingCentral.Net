namespace RingCentral
{
    public class SwitchesList
    {
        /// <summary>
        ///     Switches map
        /// </summary>
        public SwitchInfo[] records { get; set; }

        /// <summary>
        /// </summary>
        public PageNavigationModel navigation { get; set; }

        /// <summary>
        /// </summary>
        public EnumeratedPagingModel paging { get; set; }
    }
}