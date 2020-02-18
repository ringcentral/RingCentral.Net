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
        /// Http Post /restapi/v1.0/account/{accountId}/answering-rule
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Post(
            RingCentral.CompanyAnsweringRuleRequest companyAnsweringRuleRequest)
        {
            return await rc.Post<RingCentral.CompanyAnsweringRuleInfo>(this.Path(false), companyAnsweringRuleRequest);
        }

        /// <summary>
        /// Operation: Get Company Call Handling Rule List
        /// Http Get /restapi/v1.0/account/{accountId}/answering-rule
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleList> List(
            ListCompanyAnsweringRulesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.CompanyAnsweringRuleList>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get Company Call Handling Rule
        /// Http Get /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Get()
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.CompanyAnsweringRuleInfo>(this.Path());
        }

        /// <summary>
        /// Operation: Update Company Call Handling Rule
        /// Http Put /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Put(
            RingCentral.CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), companyAnsweringRuleUpdate);
        }

        /// <summary>
        /// Operation: Delete Company Call Handling Rule
        /// Http Delete /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Delete<string>(this.Path());
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