namespace RingCentral
{
    public class BridgePstnPins
    {
        /// <summary>
        ///     Host PSTN PIN. If it is not specified while creation, then a PIN will be generated.
        ///     Example: 432331057631
        /// </summary>
        public string host { get; set; }

        /// <summary>
        ///     Participant PSTN PIN. If it is not specified while creation, then a PIN will be generated.
        ///     Example: 013409241367
        /// </summary>
        public string participant { get; set; }
    }
}