namespace RingCentral
{
    public class MsTeamsUserListResponseMappings
    {
        /// <summary>
        ///     RingCentral extension ID of the user to connect
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        ///     Phone number in e.164 format (with '+' prefix)
        ///     Example: +16501234567
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Connection status of the Microsoft Teams Direct Routing user
        ///     Enum: Connected, Initial, RemoteNotFound, OutOfSync, Connecting, Disconnecting, DisconnectFailed, RemoteUserRemoved
        /// </summary>
        public string status { get; set; }
    }
}