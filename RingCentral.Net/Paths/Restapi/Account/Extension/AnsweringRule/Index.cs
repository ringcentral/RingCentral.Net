using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Extension.AnsweringRule
{
    public class Index
    {
        public Extension.Index parent;
        public RestClient rc;
        public string ruleId;

        public Index(Extension.Index parent, string ruleId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.ruleId = ruleId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ruleId != null) return $"{parent.Path()}/answering-rule/{ruleId}";
            return $"{parent.Path()}/answering-rule";
        }

        /// <summary>
        ///     Returns call handling rules of an extension.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<UserAnsweringRuleList> List(ListAnsweringRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserAnsweringRuleList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a custom call handling rule for a particular caller ID.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<CustomAnsweringRuleInfo> Post(CreateAnsweringRuleRequest createAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CustomAnsweringRuleInfo>(Path(false), createAnsweringRuleRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Returns a call handling rule by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<CallHandlingRuleInfo> Get(ReadAnsweringRuleParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Get<CallHandlingRuleInfo>(Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Updates a custom call handling rule for a particular caller ID.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<CallHandlingRuleInfo> Put(UpdateAnsweringRuleRequest updateAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Put<CallHandlingRuleInfo>(Path(), updateAnsweringRuleRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a custom call handling rule by a particular ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditExtensions
        ///     User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public AnsweringRule.Index AnsweringRule(string ruleId = null)
        {
            return new AnsweringRule.Index(this, ruleId);
        }
    }
}