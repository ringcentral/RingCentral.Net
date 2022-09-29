namespace RingCentral
{
    /// <summary>
    ///     Represents a failure of adding opt-out / opt-in. A pair of a recipient phone number and an error message
    /// </summary>
    public class OptOutBulkAssignFailedEntry
    {
        /// <summary>
        ///     A recipient phone number
        ///     Example: +15551237756
        /// </summary>
        public string to { get; set; }

        /// <summary>
        ///     An error happened on adding opt-out / opt-in
        ///     Example: Unexpected issue on creating an opt-out from bulk-assign request
        /// </summary>
        public string errorMessage { get; set; }
    }
}