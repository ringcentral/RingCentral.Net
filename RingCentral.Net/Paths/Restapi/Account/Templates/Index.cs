using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Account.Templates
{
    public partial class Index
    {
        public RestClient rc;
        public string templateId;
        public Restapi.Account.Index parent;

        public Index(Restapi.Account.Index parent, string templateId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.templateId = templateId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && templateId != null)
            {
                return $"{parent.Path()}/templates/{templateId}";
            }

            return $"{parent.Path()}/templates";
        }

        /// <summary>
        /// Operation: Get User Template List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/templates
        /// Rate Limit Group: Medium
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.UserTemplates> List(ListUserTemplatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.UserTemplates>(this.Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        /// Operation: Get User Template
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/templates/{templateId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadCompanyInfo
        /// </summary>
        public async Task<RingCentral.TemplateInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.templateId == null)
            {
                throw new System.ArgumentNullException("templateId");
            }

            return await rc.Get<RingCentral.TemplateInfo>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.Templates.Index Templates(string templateId = null)
        {
            return new Restapi.Account.Templates.Index(this, templateId);
        }
    }
}