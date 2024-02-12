namespace RingCentral
{
    public class BulkDeleteUsersRequest
    {
        /// <summary>
        ///     Indicates that the freed users' assets (phone numbers and devices) should be moved
        ///     to account inventory rather than deleted. If set to `true`, the phone numbers and devices
        ///     assigned to deleted extensions will be kept in the account's inventory. If set to `false`,
        ///     these assets will be deleted from the account and returned to either the partner's phone
        ///     numbers or RingCentral's phone number pool
        ///     Default: true
        /// </summary>
        public bool? keepAssetsInInventory { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public BulkOperationExtensionReference[] records { get; set; }
    }
}