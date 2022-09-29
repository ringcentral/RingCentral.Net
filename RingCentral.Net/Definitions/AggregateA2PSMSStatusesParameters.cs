namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation aggregateA2PSMSStatuses
    /// </summary>
    public class AggregateA2PSMSStatusesParameters
    {
        /// <summary>
        ///     List of phone numbers (specified in 'to' or 'from' fields of a message) to filter the results. Maximum number of
        ///     phone numbers allowed to be specified as filters is 15
        ///     Example: 15551234455,15551235577
        /// </summary>
        public string[] phoneNumber { get; set; }
    }
}