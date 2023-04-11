namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listCompanyActiveCalls
    /// </summary>
    public class ListCompanyActiveCallsParameters
    {
        /// <summary>
        ///     The direction of call records to be included in the result. If omitted, both
        ///     inbound and outbound calls are returned. Multiple values are supported
        ///     Enum: Inbound, Outbound
        /// </summary>
        public string[] direction { get; set; }

        /// <summary>
        ///     Defines the level of details for returned call records
        ///     Default: Simple
        ///     Enum: Simple, Detailed
        /// </summary>
        public string view { get; set; }

        /// <summary>
        ///     The type of call records to be included in the result.
        ///     If omitted, all call types are returned. Multiple values are supported
        ///     Enum: Voice, Fax
        /// </summary>
        public string[] type { get; set; }

        /// <summary>
        ///     The type of call transport. Multiple values are supported. By default this filter is disabled
        ///     Enum: PSTN, VoIP
        /// </summary>
        public string[] transport { get; set; }

        /// <summary>
        ///     Conference call type: RCC or RC Meetings. If not specified, no conference call filter applied
        ///     Enum: AudioConferencing, Meetings
        /// </summary>
        public string[] conferenceType { get; set; }

        /// <summary>
        ///     Indicates the page number to retrieve. Only positive number values are accepted
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     Indicates the page size (number of items)
        ///     Minimum: 1
        ///     Format: int32
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }
    }
}