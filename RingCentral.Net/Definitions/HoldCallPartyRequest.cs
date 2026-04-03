namespace RingCentral
{
    public class HoldCallPartyRequest
    {
        /// <summary>
        ///     Protocol for hold mode initiation
        ///     Default: Auto
        ///     Enum: Auto, RC, BroadWorks, DisconnectHolder, BroadWorksOrDisconnectHolder
        /// </summary>
        public string proto { get; set; }
    }
}