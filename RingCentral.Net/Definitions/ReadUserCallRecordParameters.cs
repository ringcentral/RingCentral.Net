namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readUserCallRecord
    /// </summary>
    public class ReadUserCallRecordParameters
    {
        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }
    }
}