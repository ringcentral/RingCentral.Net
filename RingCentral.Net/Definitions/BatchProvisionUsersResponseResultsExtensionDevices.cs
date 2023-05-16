namespace RingCentral
{
    public class BatchProvisionUsersResponseResultsExtensionDevices
    {
        /// <summary>
        ///     The internal identifier of device created
        ///     Example: 12345
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }
    }
}