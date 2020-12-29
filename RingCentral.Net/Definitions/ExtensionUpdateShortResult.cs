namespace RingCentral
{
    public class ExtensionUpdateShortResult
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId;

        /// <summary>
        /// Extension update status
        /// Enum: Fail, Success
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors;
    }
}