namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation readCompanyCallRecord
    /// </summary>
    public class ReadCompanyCallRecordParameters
    {
        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }
    }
}