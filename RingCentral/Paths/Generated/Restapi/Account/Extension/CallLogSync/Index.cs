using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.CallLogSync
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;

        public Index(Restapi.Account.Extension.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/call-log-sync";
        }

        public async Task<RingCentral.CallLogSync> Get(GetQueryParams queryParams = null)
        {
            return await rc.Get<RingCentral.CallLogSync>(this.Path(), queryParams);
        }

        public async Task<RingCentral.CallLogSync> Get(object queryParams)
        {
            return await rc.Get<RingCentral.CallLogSync>(this.Path(), queryParams);
        }
    }

    public class GetQueryParams
    {
        // Type of synchronization
        public string[] syncType;

        // Value of syncToken property of last sync request response
        public string syncToken;

        // The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is the current moment
        public string dateFrom;

        // For 'FSync' the parameter is mandatory, it limits the number of records to be returned in response. For 'ISync' it specifies with how many records to extend sync Frame to the past, the maximum number of records is 250
        public long? recordCount;

        // Type of calls to be returned. The default value is 'All'
        public string[] statusGroup;

        // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        // Enum: Simple, Detailed
        public string view;
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.CallLogSync.Index CallLogSync()
        {
            return new Restapi.Account.Extension.CallLogSync.Index(this);
        }
    }
}