using System.Threading.Tasks;

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

        public async Task<string> List(ListQueryParams queryParams = null)
        {
            return await rc.Get<string>(this.Path(false), queryParams);
        }

        public async Task<string> List(object queryParams)
        {
            return await rc.Get<string>(this.Path(false), queryParams);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Post(
            RingCentral.CreateAnsweringRuleRequest createAnsweringRuleRequest)
        {
            return await rc.Post<RingCentral.AnsweringRuleInfo>(this.Path(false), createAnsweringRuleRequest);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Post(object createAnsweringRuleRequest)
        {
            return await rc.Post<RingCentral.AnsweringRuleInfo>(this.Path(false), createAnsweringRuleRequest);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Get(GetQueryParams queryParams = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Get(object queryParams)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Put(
            RingCentral.UpdateAnsweringRuleRequest updateAnsweringRuleRequest)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest);
        }

        public async Task<RingCentral.AnsweringRuleInfo> Put(object updateAnsweringRuleRequest)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest);
        }

        public async Task<string> Delete()
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Delete<string>(this.Path());
        }
    }

    public class ListQueryParams
    {
        public string page;

        public string perPage;
    }

    public class GetQueryParams
    {
        // Indicates whether inactive numbers should be returned or not
        public bool? showInactiveNumbers;
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