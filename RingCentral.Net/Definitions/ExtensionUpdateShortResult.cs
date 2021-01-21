namespace RingCentral
{
    public class ExtensionUpdateShortResult
    {
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        public string extensionId { get; set; }

        /// <summary>
        /// Extension update status
        /// Enum: Fail, Success
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// </summary>
        public ErrorEntity[] errors { get; set; }
    }
}