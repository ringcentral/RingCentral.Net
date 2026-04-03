namespace RingCentral
{
    public class GetTimezoneListResponse
    {
        /// <summary>
        ///     Link to the timezone list resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of timezones
        ///     Required
        /// </summary>
        public TimezoneInfoBase[] records { get; set; }

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