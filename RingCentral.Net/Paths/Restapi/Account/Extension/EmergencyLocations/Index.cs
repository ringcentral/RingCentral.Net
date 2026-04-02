using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.EmergencyLocations
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Extension.Index parent;
public string locationId;
public Index(Restapi.Account.Extension.Index parent, string locationId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.locationId = locationId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && locationId != null)
            {
                return $"{parent.Path()}/emergency-locations/{locationId}";
            }
            return $"{parent.Path()}/emergency-locations";
        }
        /// <summary>
        /// Returns a list of emergency response locations available for the particular extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.EmergencyLocationsResource> List(RingCentral.GetExtensionEmergencyLocationsParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.EmergencyLocationsResource>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a personal emergency response location for the current user.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EmergencyFramework
        /// </summary>
  public async Task<RingCentral.EmergencyLocationResponseResource> Post(RingCentral.CreateUserEmergencyLocationRequest createUserEmergencyLocationRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.EmergencyLocationResponseResource>(this.Path(false), createUserEmergencyLocationRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a personal emergency response location for the current user.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.CommonEmergencyLocationResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (locationId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(locationId));
    }return await rc.Get<RingCentral.CommonEmergencyLocationResource>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates a personal emergency response location by the current user or admin.
/// 
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: EmergencyFramework
        /// </summary>
  public async Task<RingCentral.EmergencyLocationResponseResource> Put(RingCentral.EmergencyLocationRequestResource emergencyLocationRequestResource, RestRequestConfig restRequestConfig = null)
  {
if (locationId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(locationId));
    }return await rc.Put<RingCentral.EmergencyLocationResponseResource>(this.Path(), emergencyLocationRequestResource, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a personal emergency response location by ID by
/// the current user or admin. Multiple personal emergency response
/// locations can be deleted by single API call.
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/emergency-locations/{locationId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: EmergencyFramework
        /// </summary>
  public async Task<string> Delete(RingCentral.DeleteExtensionEmergencyLocationParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
if (locationId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(locationId));
    }return await rc.Delete<string>(this.Path(), null, queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.EmergencyLocations.Index EmergencyLocations(string locationId = null)
        {
            return new Restapi.Account.Extension.EmergencyLocations.Index(this, locationId);
        }
    }
}