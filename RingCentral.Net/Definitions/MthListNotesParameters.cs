namespace RingCentral
{
    /// <summary>
    /// Query parameters for operation mthListNotes
    /// </summary>
    public class MthListNotesParameters
    {
        /// <summary>
        ///     Thread owner extension IDs
        /// </summary>
        public string[] ownerExtensionIds { get; set; }

        /// <summary>
        ///     Availability filter (by default only `Alive` records are returned)
        ///     Default: Alive
        ///     Enum: Alive, Deleted
        /// </summary>
        public string[] availability { get; set; }

        /// <summary>
        ///     List of thread IDs to filter the list of results
        /// </summary>
        public string[] threadIds { get; set; }

        /// <summary>
        ///     List of note IDs to filter the list of results
        /// </summary>
        public string[] noteIds { get; set; }

        /// <summary>
        ///     The number of items per page. If the provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }
    }
}