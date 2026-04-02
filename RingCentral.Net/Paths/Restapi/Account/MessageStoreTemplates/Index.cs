using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.MessageStoreTemplates
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Index parent;
public string templateId;
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
                return $"{parent.Path()}/message-store-templates/{templateId}";
            }
            return $"{parent.Path()}/message-store-templates";
        }
        /// <summary>
        /// Returns a list of company text message templates.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.MessageTemplatesListResponse> List(RingCentral.ListCompanyMessageTemplatesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.MessageTemplatesListResponse>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a new text message template on a company level. Maximum number of company templates is 50.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.MessageTemplateResponse> Post(RingCentral.MessageTemplateRequest messageTemplateRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.MessageTemplateResponse>(this.Path(false), messageTemplateRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a company text message template by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.MessageTemplateResponse> Get(RestRequestConfig restRequestConfig = null)
  {
if (templateId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(templateId));
    }return await rc.Get<RingCentral.MessageTemplateResponse>(this.Path(), null, restRequestConfig);
  }

        /// <summary>
        /// Updates a company text message template.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<RingCentral.MessageTemplateResponse> Put(RingCentral.MessageTemplateUpdateRequest messageTemplateUpdateRequest, RestRequestConfig restRequestConfig = null)
  {
if (templateId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(templateId));
    }return await rc.Put<RingCentral.MessageTemplateResponse>(this.Path(), messageTemplateUpdateRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a company text message template.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// </summary>
  public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
  {
if (templateId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(templateId));
    }return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
  }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.MessageStoreTemplates.Index MessageStoreTemplates(string templateId = null)
        {
            return new Restapi.Account.MessageStoreTemplates.Index(this, templateId);
        }
    }
}