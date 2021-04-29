using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.AnsweringRule
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string ruleId;

        public Index(Restapi.Account.Index parent, string ruleId = null)
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
        /// Returns a list of company call handling rules.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleList> List(
            RingCentral.ListCompanyAnsweringRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyAnsweringRuleList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Creates call handling rule on account level.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Post(
            RingCentral.CompanyAnsweringRuleRequest companyAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CompanyAnsweringRuleInfo>(this.Path(false), companyAnsweringRuleRequest,
                null, restRequestConfig);
        }

        /// <summary>
        /// Returns a company call handling rule by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Updates a company call handling rule.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Put(
            RingCentral.CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), companyAnsweringRuleUpdate, null,
                restRequestConfig);
        }

        /// <summary>
        /// Deletes a company custom call handling rule by a particular ID.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.AnsweringRule.Index AnsweringRule(string ruleId = null)
        {
            return new Restapi.Account.AnsweringRule.Index(this, ruleId);
        }
    }
}