namespace RingCentral
{
    // Specifies behaviour for the missed call scenario. Returned only if `enabled` parameter of a voicemail is set to 'false'
    public class MissedCallInfo
    {
        /// <summary>
        ///     Specifies the action that should be executed on a missed call. It can either be playing greeting message and
        ///     disconnection, or sending call to a calling group. If 'ConnectToExtension' is set, then calling group extension
        ///     should be specified
        ///     Enum: PlayGreetingAndDisconnect, ConnectToExtension, ConnectToExternalNumber
        /// </summary>
        public string actionType { get; set; }

        /// <summary>
        /// </summary>
        public MissedCallExtensionInfo extension { get; set; }
    }
}