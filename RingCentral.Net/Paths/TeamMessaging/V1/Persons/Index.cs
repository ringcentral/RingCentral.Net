using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.TeamMessaging.V1.Persons
{
    public partial class Index
    {
        public RestClient rc;
public TeamMessaging.V1.Index parent;
public string personId;
public Index(TeamMessaging.V1.Index parent, string personId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.personId = personId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && personId != null)
            {
                return $"{parent.Path()}/persons/{personId}";
            }
            return $"{parent.Path()}/persons";
        }
        /// <summary>
        /// Returns a user or multiple users by their ID(s).
/// [Bulk requests](https://developers.ringcentral.com/guide/basics/batch-requests) are supported.
/// 
        /// HTTP Method: get
        /// Endpoint: /team-messaging/v1/persons/{personId}
        /// Rate Limit Group: Light
        /// App Permission: TeamMessaging
        /// </summary>
  public async Task<RingCentral.TMPersonInfo> Get(RestRequestConfig restRequestConfig = null)
  {
if (personId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(personId));
    }return await rc.Get<RingCentral.TMPersonInfo>(this.Path(), null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.TeamMessaging.V1
{
    public partial class Index
    {
        public TeamMessaging.V1.Persons.Index Persons(string personId = null)
        {
            return new TeamMessaging.V1.Persons.Index(this, personId);
        }
    }
}