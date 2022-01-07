namespace RingCentral
{
    // Transfer settings applied for department (call queue) extension type, returned if CallHandlingAction is set to `TransferToExtension`
    public class TransferredExtensionInfo
    {
        /// <summary>
        /// </summary>
        public CallHandlingExtensionInfo extension { get; set; }
    }
}