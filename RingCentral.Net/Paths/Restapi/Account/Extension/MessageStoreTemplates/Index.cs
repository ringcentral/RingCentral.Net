using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.Extension.MessageStoreTemplates
{
    public partial class Index
    {
        public RestClient rc;
public Restapi.Account.Extension.Index parent;
public string templateId;
public Index(Restapi.Account.Extension.Index parent, string templateId = null)
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
        /// Returns a list of user's personal text message templates.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store-templates
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// </summary>
  public async Task<RingCentral.MessageTemplatesListResponse> List(RingCentral.ListUserMessageTemplatesParameters queryParams = null, RestRequestConfig restRequestConfig = null)
  {
return await rc.Get<RingCentral.MessageTemplatesListResponse>(this.Path(false), queryParams, restRequestConfig);
  }

        /// <summary>
        /// Creates a user personal text message template.
/// Maximum number of personal templates is 25 per user.
/// Max length of the `body` property is 1000 symbols (2-byte UTF-16 encoded).
/// 
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store-templates
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<RingCentral.MessageTemplateResponse> Post(RingCentral.MessageTemplateRequest messageTemplateRequest, RestRequestConfig restRequestConfig = null)
  {
return await rc.Post<RingCentral.MessageTemplateResponse>(this.Path(false), messageTemplateRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Returns a user personal text message template by ID.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store-templates/{templateId}
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
        /// Updates a user personal text message template.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store-templates/{templateId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
        /// </summary>
  public async Task<RingCentral.MessageTemplateResponse> Put(RingCentral.MessageTemplateUpdateRequest messageTemplateUpdateRequest, RestRequestConfig restRequestConfig = null)
  {
if (templateId == null)
    {
        throw new System.ArgumentException("Parameter cannot be null", nameof(templateId));
    }return await rc.Put<RingCentral.MessageTemplateResponse>(this.Path(), messageTemplateUpdateRequest, null, restRequestConfig);
  }

        /// <summary>
        /// Deletes a user personal text message template.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/extension/{extensionId}/message-store-templates/{templateId}
        /// Rate Limit Group: Medium
        /// App Permission: EditExtensions
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

namespace RingCentral.Paths.Restapi.Account.Extension
{
    public partial class Index
    {
        public Restapi.Account.Extension.MessageStoreTemplates.Index MessageStoreTemplates(string templateId = null)
        {
            return new Restapi.Account.Extension.MessageStoreTemplates.Index(this, templateId);
        }
    }
}