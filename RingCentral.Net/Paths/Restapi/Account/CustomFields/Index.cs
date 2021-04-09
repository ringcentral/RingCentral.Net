using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CustomFields
{
    public class Index
    {
        public string fieldId;
        public Account.Index parent;
        public RestClient rc;

        public Index(Account.Index parent, string fieldId = null)
        {
            this.parent = parent;
            rc = parent.rc;
            this.fieldId = fieldId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && fieldId != null) return $"{parent.Path()}/custom-fields/{fieldId}";

            return $"{parent.Path()}/custom-fields";
        }

        /// <summary>
        ///     Returns the list of created custom fields.
        ///     HTTP Method: get
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields
        ///     Rate Limit Group: Light
        ///     App Permission: ReadAccounts
        ///     User Permission: ReadUserInfo
        /// </summary>
        public async Task<CustomFieldsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<CustomFieldsResource>(Path(false), null, restRequestConfig);
        }

        /// <summary>
        ///     Creates custom field attached to the object.
        ///     HTTP Method: post
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: Users
        /// </summary>
        public async Task<CustomFieldResource> Post(
            CustomFieldCreateRequest customFieldCreateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<CustomFieldResource>(Path(false), customFieldCreateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Updates custom field by ID specified in path.
        ///     HTTP Method: put
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: Users
        /// </summary>
        public async Task<CustomFieldResource> Put(
            CustomFieldUpdateRequest customFieldUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Put<CustomFieldResource>(Path(), customFieldUpdateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        ///     Deletes custom field(s) by ID(s) with the corresponding values.
        ///     HTTP Method: delete
        ///     Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}
        ///     Rate Limit Group: Light
        ///     App Permission: EditAccounts
        ///     User Permission: Users
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Delete<string>(Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public CustomFields.Index CustomFields(string fieldId = null)
        {
            return new CustomFields.Index(this, fieldId);
        }
    }
}