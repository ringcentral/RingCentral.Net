using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.AnsweringRule
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Extension.Index parent;
        public string ruleId;

        public Index(Restapi.Account.Extension.Index parent, string ruleId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.ruleId = ruleId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && ruleId != null)
            {
                return $"{parent.Path()}/answering-rule/{ruleId}";
            }

            return $"{parent.Path()}/answering-rule";
        }

        /// <summary>
        /// Returns call handling rules of an extension.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.UserAnsweringRuleList> List(
            RingCentral.ListAnsweringRulesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserAnsweringRuleList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates a custom call handling rule for a particular caller ID.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.CustomAnsweringRuleInfo> Post(
            RingCentral.CreateAnsweringRuleRequest createAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CustomAnsweringRuleInfo>(this.Path(false), createAnsweringRuleRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns an call handling rule by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Get(RingCentral.ReadAnsweringRuleParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Updates a custom call handling rule for a particular caller ID.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Put(
            RingCentral.UpdateAnsweringRuleRequest updateAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes a custom call handling rule by a particular ID.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(ruleId));
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.AnsweringRule.Index AnsweringRule(string ruleId = null)
        {
            return new Restapi.Account.Extension.AnsweringRule.Index(this, ruleId);
        }
    }
}