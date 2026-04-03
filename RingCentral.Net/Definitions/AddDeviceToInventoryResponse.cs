namespace RingCentral
{
    public class AddDeviceToInventoryResponse
    {
        /// <summary>
        ///     Required
        /// </summary>
        public AddDeviceToInventoryResponseDevices[] devices { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public SiteBasicInfo site { get; set; }
    }
}