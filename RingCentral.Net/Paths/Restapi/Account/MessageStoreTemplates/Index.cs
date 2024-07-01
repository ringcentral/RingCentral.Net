using System;
using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.MessageStoreTemplates
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
            if (withParameter && templateId != null) return $"{parent.Path()}/message-store-templates/{templateId}";
            return $"{parent.Path()}/message-store-templates";
        }

        /// <summary>
        ///     Returns a list of company text message templates.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<MessageTemplatesListResponse> List(ListCompanyMessageTemplatesParameters queryParams = null,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<MessageTemplatesListResponse>(Path(false), queryParams, restRequestConfig);
        }

        /// <summary>
        ///     Creates a new text message template on a company level. Maximum number of company templates is 50.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<MessageTemplateResponse> Post(MessageTemplateRequest messageTemplateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<MessageTemplateResponse>(Path(false), messageTemplateRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Returns a company text message template by ID.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        /// </summary>
        public async Task<MessageTemplateResponse> Get(RestRequestConfig restRequestConfig = null)
        {
            if (templateId == null) throw new ArgumentException("Parameter cannot be null", nameof(templateId));
            return await rc.Get<MessageTemplateResponse>(Path(), null, restRequestConfig);
        }

        /// <summary>
        ///     Updates a company text message template.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<MessageTemplateResponse> Put(MessageTemplateUpdateRequest messageTemplateUpdateRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (templateId == null) throw new ArgumentException("Parameter cannot be null", nameof(templateId));
            return await rc.Put<MessageTemplateResponse>(Path(), messageTemplateUpdateRequest, null, restRequestConfig);
        }

        /// <summary>
        ///     Deletes a company text message template.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/message-store-templates/{templateId}
        ///     Rate Limit Group: Medium
        ///     App Permission: EditAccounts
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (templateId == null) throw new ArgumentException("Parameter cannot be null", nameof(templateId));
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public MessageStoreTemplates.Index MessageStoreTemplates(string templateId = null)
        {
            return new MessageStoreTemplates.Index(this, templateId);
        }
    }
}