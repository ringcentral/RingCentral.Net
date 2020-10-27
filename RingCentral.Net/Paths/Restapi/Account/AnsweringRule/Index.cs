using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.AnsweringRule
{
    public partial class Index
    {
        public RestClient rc;
        public string ruleId;
        public Restapi.Account.Index parent;

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
        /// Operation: Create Company Call Handling Rule
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/answering-rule
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
        /// Operation: Get Company Call Handling Rule List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/answering-rule
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleList> List(
            ListCompanyAnsweringRulesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CompanyAnsweringRuleList>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Company Call Handling Rule
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Company Call Handling Rule
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Put(
            RingCentral.CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), companyAnsweringRuleUpdate, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Company Call Handling Rule
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: EditCompanyAnsweringRules
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