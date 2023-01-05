namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteUserCallLog
    /// </summary>
    public class DeleteUserCallLogParameters
    {
        /// <summary>
        ///     The time boundary to delete all older records in ISO 8601 format including
        ///     timezone, for example *2016-03-10T18:07:52.534Z*. The default value is current time
        ///     Format: date-time
        /// </summary>
        public string dateTo { get; set; }
    }
}