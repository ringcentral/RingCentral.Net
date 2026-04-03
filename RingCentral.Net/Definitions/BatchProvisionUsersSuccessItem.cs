namespace RingCentral
{
    public class BatchProvisionUsersSuccessItem
    {
        /// <summary>
        ///     Indicates if the provisioning operation was successful for this item, always `true` in this model
        ///     Required
        ///     Example: true
        /// </summary>
        public bool? successful { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public BatchProvisionUsersSuccessItemExtension extension { get; set; }
    }
}