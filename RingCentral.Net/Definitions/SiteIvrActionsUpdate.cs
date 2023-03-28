namespace RingCentral
{
    /// <summary>
    ///     Keys handling settings
    /// </summary>
    public class SiteIvrActionsUpdate
    {
        /// <summary>
        ///     Enum: Star, Hash, NoInput, 0
        /// </summary>
        public string input { get; set; }

        /// <summary>
        ///     Key handling action:
        ///     - Repeat - repeat menu greeting, for Star and Hash only;
        ///     - ReturnToRoot - return to root IVR menu, for Star and Hash only;
        ///     - ReturnToPrevious - return to previous IVR menu, for Star and Hash only;
        ///     - Connect - connect to specific extension, for NoInput and "0" (zero) only;
        ///     - Disconnect - end call, for NoInput only.
        ///     Enum: Repeat, ReturnToRoot, ReturnToPrevious, ReturnToTopLevelMenu, Connect, ConnectToOperator, Disconnect,
        ///     DoNothing
        /// </summary>
        public string action { get; set; }

        /// <summary>
        /// </summary>
        public SiteIVRActionsExtensionInfoUpdate extension { get; set; }
    }
}