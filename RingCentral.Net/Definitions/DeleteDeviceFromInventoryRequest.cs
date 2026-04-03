namespace RingCentral
{
    public class DeleteDeviceFromInventoryRequest
    {
        /// <summary>
        ///     List of internal identifiers of the devices that should be deleted
        ///     Required
        /// </summary>
        public DeleteDeviceFromInventoryRequestRecords[] records { get; set; }
    }
}