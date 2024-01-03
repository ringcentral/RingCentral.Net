namespace RingCentral
{
    public class RemoveLineRequest
    {
        /// <summary>
        ///     The flag that controls what to do with the number and device:
        ///     - if value ```keepAssetsInInventory == true```, the given device is moved to unassigned devices
        ///     and the number is moved to the number inventory;
        ///     - if value ```keepAssetsInInventory == false```, the given device and number is removed from the account;
        ///     - if the parameter keepAssetsInInventory is not set (empty body) or the value of the parameter is empty,
        ///     default value ```keepAssetsInInventory == true``` is used.
        ///     Required
        ///     Default: true
        /// </summary>
        public bool? keepAssetsInInventory { get; set; }
    }
}