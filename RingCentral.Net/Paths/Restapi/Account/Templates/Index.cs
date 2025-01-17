using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.Templates
{
    public class Index
    {
        public Account.Index parent;
        public RestClient rc;
        public string templateId;

        public Index(Account.Index parent, string templateId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.templateId = templateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && templateId != null) return $"{parent.Path()}/templates/{templateId}";

            return $"{parent.Path()}/templates";
        }

        /// <summary>
        ///     Returns the list of user templates for the current account.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/templates
        ///     Rate Limit Group: Medium
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<UserTemplates> List(ListUserTemplatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<UserTemplates>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Returns the user template by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/templates/{templateId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<TemplateInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (templateId == null) throw new ArgumentException("Parameter cannot be null", nameof(templateId));

            return await rc.Get<TemplateInfo>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Templates.Index Templates(string templateId = null)
        {
            return new Templates.Index(this, templateId);
        }
    }
}