using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice.StateRules
{
    public class Index
    {
        public Voice.Index parent;
        public RestClient rc;
        public string stateId;

        public Index(Voice.Index parent, string stateId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.stateId = stateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && stateId != null) return $"{parent.Path()}/state-rules/{stateId}";
            return $"{parent.Path()}/state-rules";
        }

        /// <summary>
        ///     Returns a list of extension's voice state-based rules.
        ///     *State-base rule* is a call handling rule, managing voice calls on the basis of the user's **state (status)**:
        ///     *Forward all calls (FAC), Do not disturb (DND), Work Hours (WH), After Hours (AH), Agent*.
        ///     **Please note:** State-based rules are applicable to the User extension types only: User, DigitalUser, FaxUser,
        ///     VirtualUser.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/state-rules
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommStateBasedRulesResource> List(ListVoiceStateBasedRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CommStateBasedRulesResource>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the extension's voice state-based rule by ID specified in URL. Each state is assigned
        ///     with the predefined ID.
        ///     *State-base rule* is a call handling rule, managing voice calls on the basis of the user's **state (status)**:
        ///     *Forward all calls (FAC), Do not disturb (DND), Work Hours (WH), After Hours (AH), Agent*.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/state-rules/{stateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<CommStateBasedRuleResource> Get(RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null) throw new ArgumentException("Parameter cannot be null", nameof(stateId));
            return await rc.Get<CommStateBasedRuleResource>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates the extension's voice state-based rule.
        ///     **Please note:**  When updating any of objects: `enabled`, `displayName`, `dispatching`, `condition`, etc.
        ///     all of object parameters should be passed (as in PUT method) - if a parameter is not specified,
        ///     its value will be set back to default, if any, or deleted.
        ///     HTTP Method: patch
        ///     Endpoint: /restapi/v2/accounts/{accountId}/extensions/{extensionId}/comm-handling/voice/state-rules/{stateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        /// </summary>
        public async Task<CommStateBasedRuleResource> Patch(
            CommStateBasedRuleUpdateRequest commStateBasedRuleUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (stateId == null) throw new ArgumentException("Parameter cannot be null", nameof(stateId));
            return await rc.Patch<CommStateBasedRuleResource>(Path(), commStateBasedRuleUpdateRequest, null,
                restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.V2.Accounts.Extensions.CommHandling.Voice
{
    public partial class Index
    {
        public StateRules.Index StateRules(string stateId = null)
        {
            return new StateRules.Index(this, stateId);
        }
    }
}