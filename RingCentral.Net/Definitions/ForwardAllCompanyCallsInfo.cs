namespace RingCentral
{
    public class ForwardAllCompanyCallsInfo
    {
        /// <summary>
        ///     Indicates whether the Forward All Company Calls feature is enabled or disabled for account
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Specific data ranges. If specified, weeklyRanges cannot be specified
        /// </summary>
        public RangesInfo[] ranges { get; set; }

        /// <summary>
        ///     Specifies how incoming calls are forwarded. The default value
        ///     is 'Operator' 'Operator' - play company greeting and forward to operator
        ///     extension 'Disconnect' - play company greeting and disconnect 'Bypass'
        ///     - bypass greeting to go to selected extension = ['Operator', 'Disconnect',
        ///     'Bypass']
        ///     Enum: Operator, Disconnect, Bypass
        /// </summary>
        public string callHandlingAction { get; set; }

        /// <summary>
        /// </summary>
        public ExtensionShortInfoResource extension { get; set; }

        /// <summary>
        /// </summary>
        public ForwardAllCallsReason reason { get; set; }
    }
}