namespace RingCentral
{
    public class CallsByEndingParty
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
        public CallsByEndingPartyBreakdown values { get; set; }
    }
}