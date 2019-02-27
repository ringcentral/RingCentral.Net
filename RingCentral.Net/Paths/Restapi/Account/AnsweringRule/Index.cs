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

        // Operation: createCompanyAnsweringRule
        // Http Post /restapi/v1.0/account/{accountId}/answering-rule
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Post(
            RingCentral.CompanyAnsweringRuleRequest companyAnsweringRuleRequest)
        {
            return await rc.Post<RingCentral.CompanyAnsweringRuleInfo>(this.Path(false), companyAnsweringRuleRequest);
        }

        // Operation: listCompanyAnsweringRule
        // Http Get /restapi/v1.0/account/{accountId}/answering-rule
        public async Task<RingCentral.CompanyAnsweringRuleList> List()
        {
            return await rc.Get<RingCentral.CompanyAnsweringRuleList>(this.Path(false));
        }

        // Operation: loadCompanyAnsweringRule
        // Http Get /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Get()
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.CompanyAnsweringRuleInfo>(this.Path());
        }

        // Operation: updateCompanyAnsweringRule
        // Http Put /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
        public async Task<RingCentral.CompanyAnsweringRuleInfo> Put(
            RingCentral.CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.CompanyAnsweringRuleInfo>(this.Path(), companyAnsweringRuleUpdate);
        }

        // Operation: deleteCompanyAnsweringRule
        // Http Delete /restapi/v1.0/account/{accountId}/answering-rule/{ruleId}
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