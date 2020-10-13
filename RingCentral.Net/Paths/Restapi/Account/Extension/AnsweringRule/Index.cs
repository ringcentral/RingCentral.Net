using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Extension.AnsweringRule
{
    public partial class Index
    {
        public RestClient rc;
        public string ruleId;
        public Restapi.Account.Extension.Index parent;

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
        /// Operation: Get Call Handling Rules
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.UserAnsweringRuleList> List(ListAnsweringRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserAnsweringRuleList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Call Handling Rule
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
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
        /// Operation: Get Call Handling Rule
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Get(ReadAnsweringRuleParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Call Handling Rule
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Put(
            RingCentral.UpdateAnsweringRuleRequest updateAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Call Handling Rule
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// User Permission: EditUserAnsweringRules
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
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