namespace RingCentral
{
    public class AnalyticsLegacyCallActionFilter
    {
        /// <summary>
        ///     Required
        ///     Enum: HoldOff, HoldOn, ParkOn, ParkOff, BlindTransfer, WarmTransfer, DTMFTransfer
        /// </summary>
        public string callAction { get; set; }
    }
}