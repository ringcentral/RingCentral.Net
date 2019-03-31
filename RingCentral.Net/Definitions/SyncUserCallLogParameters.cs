namespace RingCentral
{
    public class SyncUserCallLogParameters
    {
        /* Type of synchronization */
        public string[] syncType;

        /* Value of syncToken property of last sync request response */
        public string syncToken;

        /* The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment */
        public string dateFrom;

        /* For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250 */
        public long? recordCount;

        /* Type of calls to be returned. The default value is 'All' */
        public string[] statusGroup;

        /* View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync */
        // Default: Simple
        // Enum: Simple, Detailed
        public string view;

        /* Supproted for ISync. If 'True' then deleted call records are returned */
        public bool? showDeleted;
    }
}