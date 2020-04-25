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
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
        /// </summary>
        public async Task<RingCentral.UserAnsweringRuleList> List(ListAnsweringRulesParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Get<RingCentral.UserAnsweringRuleList>(this.Path(false), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Create Call Handling Rule
        /// Http Post /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule
        /// </summary>
        public async Task<RingCentral.CustomAnsweringRuleInfo> Post(
            RingCentral.CreateAnsweringRuleRequest createAnsweringRuleRequest,
            CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.CustomAnsweringRuleInfo>(this.Path(false), createAnsweringRuleRequest,
                null, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Call Handling Rule
        /// Http Get /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Get(ReadAnsweringRuleParameters queryParams = null,
            CancellationToken? cancellationToken = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Get<RingCentral.AnsweringRuleInfo>(this.Path(), queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Call Handling Rule
        /// Http Put /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<RingCentral.AnsweringRuleInfo> Put(
            RingCentral.UpdateAnsweringRuleRequest updateAnsweringRuleRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Put<RingCentral.AnsweringRuleInfo>(this.Path(), updateAnsweringRuleRequest, null,
                cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Call Handling Rule
        /// Http Delete /restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.ruleId == null)
            {
                throw new System.ArgumentNullException("ruleId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
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