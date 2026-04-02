using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.InteractionRules
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.V2.Accounts.Extensions.CommHandling.Voice.Index parent;
public string ruleId;
public Index(Restapi.V2.Accounts.Extensions.CommHandling.Voice.Index parent, string ruleId = null)
      {
this.parent = parent;
this.rc = parent.rc;
this.ruleId = ruleId;
}
        public string Path(bool withParameter = true)
        {
            if (withParameter && ruleId != null)
            {
                return $"{parent.Path()}/interaction-rules/{ruleId}";
            }
            return $"{parent.Path()}/interaction-rules";
        }
        /// <summary>
        /// Returns a list of extension's interaction rules with the detailed information on each rule.
/// 
/// *Interaction* rule is a call handling rule, managing voice call on the basis
/// of the user's **contact** or a **phone number** which is calling and/or being called.
/// 
/// **Please note:** Interaction rules are applicable to the User extension types only: User, DigitalUser,
/// FaxUser, VirtualUser.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.CommInteractionRulesResource> List(RingCentral.ListVoiceInteractionRulesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.CommInteractionRulesResource>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates the extension's interaction rule.
/// 
/// *Interaction* rule is a call handling rule, managing voice call on the basis
/// of the user's **contact** or a **phone number** which is calling and/or being called.
/// 
/// **Please note:** Interaction rules are applicable to the User extension types only: User, DigitalUser,
/// FaxUser, VirtualUser.
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<RingCentral.CommInteractionRuleResource> Post(RingCentral.CommInteractionRuleCreateRequest commInteractionRuleCreateRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.CommInteractionRuleResource>(this.Path(false), commInteractionRuleCreateRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns the extension's interaction rule by ID specified in URL.
/// 
/// *Interaction* rule is a call handling rule, managing voice call on the basis
/// of the user's **contact** or a **phone number** which is calling and/or being called.
/// 
        /// HTTP Method: get
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.CommInteractionRuleResource> Get(RestRequestConfig restRequestConfig = null)
  {
if (ruleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
    }return await rc.Get<RingCentral.CommInteractionRuleResource>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Deletes the extension's interaction rule by ID specified in URL.
        /// HTTP Method: delete
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (ruleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }

        /// <summary>
        /// Updates the extension's interaction rule by ID specified in URL.
        /// HTTP Method: patch
        /// Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<RingCentral.CommInteractionRuleResource> Patch(RingCentral.CommInteractionRuleUpdateRequest commInteractionRuleUpdateRequest, RestRequestConfig restRequestConfig = null)
  {
if (ruleId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
    }return await rc.Patch<RingCentral.CommInteractionRuleResource>(this.Path(), commInteractionRuleUpdateRequest, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public Restapi.V2.Accounts.Extensions.CommHandling.Voice.InteractionRules.Index InteractionRules(string ruleId = null)
        {
            return new Restapi.V2.Accounts.Extensions.CommHandling.Voice.InteractionRules.Index(this, ruleId);
        }
    }
}