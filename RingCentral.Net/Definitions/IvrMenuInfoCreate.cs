namespace RingCentral
{
    public class IvrMenuInfoCreate
    {
        /// <summary>
        ///     First name of an IVR Menu user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Number of an IVR Menu extension
        /// </summary>
        public string extensionNumber { get; set; }

        /// <summary>
        /// </summary>
        public IvrMenuSiteInfo site { get; set; }

        /// <summary>
        /// </summary>
        public IvrMenuPromptInfo prompt { get; set; }

        /// <summary>
        ///     Keys handling settings
        /// </summary>
        public IvrMenuActionsInfo[] actions { get; set; }

        /// <summary>
        ///     Number of attempts the IVR prompt will be played during a call before
        ///     the "NoInput" rule will be executed. For request payloads, unsupported
        ///     values return a `CMN-101` error.
        ///     Format: int32
        ///     Default: 3
        ///     Enum: 1, 2, 3
        /// </summary>
        public long? promptRepeatCount { get; set; }
    }
}