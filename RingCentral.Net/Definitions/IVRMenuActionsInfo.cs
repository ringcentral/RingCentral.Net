namespace RingCentral
{
    public class IVRMenuActionsInfo
    {
        /// <summary>
        ///     Key. The following values are supported: numeric: '1' to '9' Star Hash NoInput
        /// </summary>
        public string input { get; set; }

        /// <summary>
        ///     Internal identifier of an answering rule
        ///     Enum: Connect, Voicemail, DialByName, Transfer, Repeat, ReturnToRoot, ReturnToPrevious, Disconnect, ReturnToTopLevelMenu, DoNothing, ConnectToOperator
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// </summary>
        public IVRMenuExtensionInfo extension { get; set; }

        /// <summary>
        ///     For 'Transfer' action only. PSTN number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}