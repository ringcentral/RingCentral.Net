namespace RingCentral
{
    /// <summary>
    ///     Data for calls with breakdown by action (HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer,
    ///     DTMFTransfer)
    /// </summary>
    public class CallsByActions
    {
        /// <summary>
        ///     Unit of the result value
        ///     Required
        ///     Enum: Percent, Seconds, Instances
        /// </summary>
        public string valueType { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public CallsByActionsBreakdown values { get; set; }
    }
}