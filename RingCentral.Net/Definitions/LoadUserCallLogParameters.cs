namespace RingCentral
{
    public class LoadUserCallLogParameters
    {
        /* Extension number of a user. If specified, returns call log for a particular extension only */
        public string extensionNumber;

        /* If 'True' then calls from/to blocked numbers are returned */
        // Default: true
        public bool? showBlocked;

        /* Phone number of a caller/callee. If specified, returns all calls (both incoming and outcoming) with the phone number specified */
        public string phoneNumber;

        /* The direction for the resulting records. If not specified, both inbound and outbound records are returned. Multiple values are accepted */
        public string[] direction;

        /* Internal identifier of a session */
        public string sessionId;

        /* Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted */
        public string[] type;

        /* Call transport type. 'PSTN' specifies that a call leg is initiated from the PSTN network provider; 'VoIP' - from an RC phone. By default this filter is disabled */
        public string[] transport;

        /* View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync */
        // Default: Simple
        // Enum: Simple, Detailed
        public string view;

        /* **Deprecated**. Supported for compatibility reasons. `True` if only recorded calls are returned. If both `withRecording` and `recordingType` are specified, then `withRecording` is ignored */
        public bool? withRecording;

        /* Type of a call recording. If not specified, then calls without recordings are also returned */
        // Enum: Automatic, OnDemand, All
        public string recordingType;

        /* The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time */
        public string dateTo;

        /* The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours */
        public string dateFrom;

        /* Indicates the page number to retrieve. Only positive number values are allowed */
        // Default: 1
        public long? page;

        /* Indicates the page size (number of items) */
        // Default: 100
        public long? perPage;

        /* If 'True' then deleted calls are returned */
        public bool? showDeleted;
    }
}