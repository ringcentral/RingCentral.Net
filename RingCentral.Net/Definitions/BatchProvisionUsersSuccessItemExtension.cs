namespace RingCentral
{
    public class BatchProvisionUsersSuccessItemExtension
    {
        /// <summary>
        ///     The internal identifier of RingCentral extension created
        ///     Example: 12345
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersSuccessItemExtensionDevices[] devices { get; set; }
    }
}