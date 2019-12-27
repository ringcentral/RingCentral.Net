namespace RingCentral
{
    public class ReadCompanyCallLogParameters
    {
        /// <summary>
        /// Extension number of a user. If specified, returns call log for a particular extension only
        /// </summary>
        public string extensionNumber;

        /// <summary>
        /// Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the phone number specified. Cannot be specified together with the extensionNumber filter
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// The direction for the result records. If not specified, both inbound and outbound records are returned. Multiple values are accepted
        /// </summary>
        public string[] direction;

        /// <summary>
        /// Call type of a record. If not specified, all call types are returned. Multiple values are accepted
        /// </summary>
        public string[] type;

        /// <summary>
        /// View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        /// Default: Simple
        /// Enum: Simple, Detailed
        /// </summary>
        public string view;

        /// <summary>
        /// **Deprecated**. Supported for compatibility reasons only. `true` if only recorded calls are returned. The default value is `false`. If both `withRecording` and `recordingType` are specified, `withRecording` is ignored
        /// </summary>
        public bool? withRecording;

        /// <summary>
        /// Type of a call recording. If not specified, then calls without recordings are also returned
        /// Enum: Automatic, OnDemand, All
        /// </summary>
        public string recordingType;

        /// <summary>
        /// The start datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
        /// </summary>
        public string dateFrom;

        /// <summary>
        /// The end datetime for resulting records in (ISO 8601)[https://en.wikipedia.org/wiki/ISO_8601]  format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
        /// </summary>
        public string dateTo;

        /// <summary>
        /// Indicates the page number to retrieve. Only positive number values are accepted
        /// Default: 1
        /// </summary>
        public long? page;

        /// <summary>
        /// Indicates the page size (number of items)
        /// Default: 100
        /// </summary>
        public long? perPage;

        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        public string sessionId;
    }
}