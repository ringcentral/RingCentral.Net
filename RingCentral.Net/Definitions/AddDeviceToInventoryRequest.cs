namespace RingCentral
{
    public class AddDeviceToInventoryRequest
    {
        /// <summary>
        ///     Device type. Use `OtherPhone` to indicate BYOD (customer provided) device
        ///     Required
        ///     Enum: OtherPhone
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     Quantity of devices (total quantity should not exceed 50)
        ///     Required
        ///     Maximum: 50
        ///     Minimum: 1
        ///     Format: int32
        /// </summary>
        public long? quantity { get; set; }

        /// <summary>
        /// </summary>
        public AddDeviceToInventoryRequestSite site { get; set; }
    }
}