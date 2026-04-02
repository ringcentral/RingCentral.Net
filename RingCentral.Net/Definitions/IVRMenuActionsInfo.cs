namespace RingCentral
  {
      public class IvrMenuActionsInfo
      {
          /// <summary>
        ///     Key pressed by the user
        ///     Enum: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, Hash, Star, NoInput
        /// </summary>
        public string input { get; set; }

        /// <summary>
        ///     Action to be taken on key press
        ///     Enum: Connect, Voicemail, DialByName, Transfer, Repeat, ReturnToRoot, ReturnToPrevious, Disconnect, ReturnToTopLevelMenu, DoNothing, ConnectToOperator, TransferToContactCenterNumber, ConnectToIncomingCallRoutingSelection
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// </summary>
        public IvrMenuExtensionInfo extension { get; set; }

        /// <summary>
        ///     For 'Transfer' action only. PSTN number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }
      }
  }