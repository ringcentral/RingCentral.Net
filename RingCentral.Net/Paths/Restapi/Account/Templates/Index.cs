using System.Threading.Tasks;

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
        /// Http Get /restapi/v1.0/account/{accountId}/templates
        /// </summary>
        public async Task<RingCentral.UserTemplates> List(ListUserTemplatesParameters queryParams = null)
        {
            return await rc.Get<RingCentral.UserTemplates>(this.Path(false), queryParams);
        }

        /// <summary>
        /// Operation: Get User Template
        /// Http Get /restapi/v1.0/account/{accountId}/templates/{templateId}
        /// </summary>
        public async Task<RingCentral.TemplateInfo> Get()
        {
            if (this.templateId == null)
            {
                throw new System.ArgumentNullException("templateId");
            }

            return await rc.Get<RingCentral.TemplateInfo>(this.Path());
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