namespace RingCentral
{
    public class BulkSupported
    {
        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? maxOperations { get; set; }

        /// <summary>
        ///     Format: int32
        /// </summary>
        public long? maxPayloadSize { get; set; }

        /// <summary>
        /// </summary>
        public bool? supported { get; set; }
    }
}