namespace RingCentral
{
    public class BatchProvisionUsersResponseResultsExtension
    {
        /// <summary>
        ///     The internal identifier of RingCentral extension created
        ///     Example: 12345
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// </summary>
        public BatchProvisionUsersResponseResultsExtensionDevices[] devices { get; set; }
    }
}