namespace RingCentral
{
    public class IVRMenuActionsInfo
    {
        /// <summary>
        /// Key. The following values are supported: numeric: '1' to '9' Star Hash NoInput
        /// </summary>
        public string input;

        /// <summary>
        /// Internal identifier of an answering rule
        /// Enum: Connect, Voicemail, DialByName, Transfer, Repeat, ReturnToRoot, ReturnToPrevious, Disconnect
        /// </summary>
        public string action;

        /// <summary>
        /// For 'Connect' or 'Voicemail' actions only. Extension reference
        /// </summary>
        public IVRMenuExtensionInfo extension;

        /// <summary>
        /// For 'Transfer' action only. PSTN number in E.164 format
        /// </summary>
        public string phoneNumber;
    }
}