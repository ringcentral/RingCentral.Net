namespace RingCentral
{
    public class TransferExtensionInfo
    {
        /// <summary>
        ///     Internal identifier of an extension the call is transferred to
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Extension name
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Extension number
        /// </summary>
        public string extensionNumber { get; set; }
    }
}