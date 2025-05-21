using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.InteractionRules
{
    public class Index
    {
        public Voice.Index parent;
        public RestClient rc;
        public string ruleId;

        public Index(Voice.Index parent, string ruleId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.ruleId = ruleId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ruleId != null) return $"{parent.Path()}/interaction-rules/{ruleId}";
            return $"{parent.Path()}/interaction-rules";
        }

        /// <summary>
        ///     Returns a list of extension's interaction rules with the detailed information on each rule.
        ///     *Interaction* rule is a call handling rule, managing voice call on the basis
        ///     of the user's **contact** or a **phone number** which is calling and/or being called.
        ///     **Please note:** Interaction rules are applicable to the User extension types only: User, DigitalUser,
        ///     FaxUser, VirtualUser.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommInteractionRulesResource> List(ListVoiceInteractionRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CommInteractionRulesResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates the extension's interaction rule.
        ///     *Interaction* rule is a call handling rule, managing voice call on the basis
        ///     of the user's **contact** or a **phone number** which is calling and/or being called.
        ///     **Please note:** Interaction rules are applicable to the User extension types only: User, DigitalUser,
        ///     FaxUser, VirtualUser.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<CommInteractionRuleResource> Post(
            CommInteractionRuleCreateRequest commInteractionRuleCreateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CommInteractionRuleResource>(Path(false), commInteractionRuleCreateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns the extension's interaction rule by ID specified in URL.
        ///     *Interaction* rule is a call handling rule, managing voice call on the basis
        ///     of the user's **contact** or a **phone number** which is calling and/or being called.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommInteractionRuleResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Get<CommInteractionRuleResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes the extension's interaction rule by ID specified in URL.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Delete<string>(Path(), null, null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the extension's interaction rule by ID specified in URL.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/interaction-rules/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<CommInteractionRuleResource> Patch(
            CommInteractionRuleUpdateRequest commInteractionRuleUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Patch<CommInteractionRuleResource>(Path(), commInteractionRuleUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public InteractionRules.Index InteractionRules(string ruleId = null)
        {
            return new InteractionRules.Index(this, ruleId);
        }
    }
}