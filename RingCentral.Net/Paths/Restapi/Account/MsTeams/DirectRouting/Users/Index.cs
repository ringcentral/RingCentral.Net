using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MsTeams.DirectRouting.Users
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.MsTeams.DirectRouting.Index parent;
public Index(Restapi.Account.MsTeams.DirectRouting.Index parent)
      {
this.parent = parent;
this.rc = parent.rc;
}
        public string Path(bool withParameter = false)
        {
            return $"{parent.Path()}/users";
        }
        /// <summary>
        /// Returns the list of Microsoft Teams Direct Routing users and their connection status with the integration,
/// filtered by provided RingCentral extension IDs (up to 25 users at a time).
/// 
/// Before using this API, the account-level setup for Direct Routing must be completed as described in
/// [this guide](https://support.ringcentral.com/article-v2/Enabling-direct-routing-in-RingCentral-and-Microsoft-Teams.html?brand=RingCentral&product=RingEX&language=en_US).
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ms-teams/direct-routing/users
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.MsTeamsUserListResponse> Get(RingCentral.ListTeamsUsersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.MsTeamsUserListResponse>(this.Path(), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Connects Microsoft Teams Direct Routing users in bulk asynchronously (up to 25 users at a time).
/// 
/// Before using this API, the account-level setup for Direct Routing must be completed as described in
/// [this guide](https://support.ringcentral.com/article-v2/Enabling-direct-routing-in-RingCentral-and-Microsoft-Teams.html?brand=RingCentral&product=RingEX&language=en_US).
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ms-teams/direct-routing/users
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.MsTeamsUserListResponse> Post(RingCentral.ConnectTeamsUsersRequest connectTeamsUsersRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.MsTeamsUserListResponse>(this.Path(), connectTeamsUsersRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Disconnects Microsoft Teams Direct Routing users in bulk asynchronously  (up to 25 users at a time).
/// 
/// Before using this API, the account-level setup for Direct Routing must be completed as described in
/// [this guide](https://support.ringcentral.com/article-v2/Enabling-direct-routing-in-RingCentral-and-Microsoft-Teams.html?brand=RingCentral&product=RingEX&language=en_US).
/// 
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/ms-teams/direct-routing/users
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<string> Delete(RingCentral.DisconnectTeamsUsersParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Delete<string>(this.Path(), null, queryParams, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account.MsTeams.DirectRouting
{
    public partial class Index
    {
        public Restapi.Account.MsTeams.DirectRouting.Users.Index Users()
        {
            return new Restapi.Account.MsTeams.DirectRouting.Users.Index(this);
        }
    }
}