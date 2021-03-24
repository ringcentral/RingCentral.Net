namespace RingCentral
{
    // Query parameters for operation readUserCallRecord
    public class ReadUserCallRecordParameters
    {
        /// <summary>
        /// View of call records. The view value specified for 'FSync' will also be applied for 'ISync' by default, since it cannot be changed for ISync
        /// Default: Simple
        /// Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }
    }
}