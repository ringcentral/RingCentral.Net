using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AnsweringRule
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string ruleId;

        public Index(Account.Index parent, string ruleId = null)
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
        ///     Returns a list of company call handling rules.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<CompanyAnsweringRuleList> List(
            ListCompanyAnsweringRulesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CompanyAnsweringRuleList>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates call handling rule on account level.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<CompanyAnsweringRuleInfo> Post(
            CompanyAnsweringRuleRequest companyAnsweringRuleRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CompanyAnsweringRuleInfo>(Path(false), companyAnsweringRuleRequest,
                null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a company call handling rule by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<CompanyAnsweringRuleInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));

            return await rc.Get<CompanyAnsweringRuleInfo>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a company call handling rule.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<CompanyAnsweringRuleInfo> Put(
            CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));

            return await rc.Put<CompanyAnsweringRuleInfo>(Path(), companyAnsweringRuleUpdate, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes a company custom call handling rule by a particular ID.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/answering-rule/{ruleId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        ///     User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (ruleId == null) throw new ArgumentException("Parameter cannot be null", nameof(ruleId));

            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public AnsweringRule.Index AnsweringRule(string ruleId = null)
        {
            return new AnsweringRule.Index(this, ruleId);
        }
    }
}