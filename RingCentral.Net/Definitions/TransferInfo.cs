namespace RingCentral
{
    public class TransferInfo
    {
        /// <summary>
        /// </summary>
        public TransferExtensionInfo extension;

        /// <summary>
        /// Event that initiates transferring to the specified extension
        /// Enum: HoldTimeExpiration, MaxCallers, NoAnswer
        /// </summary>
        public string action;
    }
}