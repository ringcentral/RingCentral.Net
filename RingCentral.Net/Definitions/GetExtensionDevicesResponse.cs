namespace RingCentral
{
    public class GetExtensionDevicesResponse
    {
        /// <summary>
        ///     Link to a list of extension devices
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        ///     List of extension devices
        ///     Required
        /// </summary>
        public DeviceResource[] records { get; set; }

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