namespace RingCentral
{
    public class TransferInfo
    {
        /// <summary>
        /// </summary>
        public TransferExtensionInfo extension { get; set; }

        /// <summary>
        /// Event that initiates transferring to the specified extension
        /// Enum: HoldTimeExpiration, MaxCallers, NoAnswer
        /// </summary>
        public string action { get; set; }
    }
}