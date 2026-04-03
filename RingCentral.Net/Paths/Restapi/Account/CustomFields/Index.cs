using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;

namespace RingCentral.Paths.Restapi.Account.CustomFields
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Account.Index parent;
        public string fieldId;
        public Index(Restapi.Account.Index parent, string fieldId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.fieldId = fieldId;
        }
        public string Path(bool withParameter = true)
        {
            if (withParameter && fieldId != null)
            {
                return $"{parent.Path()}/custom-fields/{fieldId}";
            }
            return $"{parent.Path()}/custom-fields";
        }
        /// <summary>
        /// Returns the list of created custom fields.
        /// HTTP Method: get
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomFieldList> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CustomFieldList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Creates custom field attached to the object.
        /// HTTP Method: post
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.CustomFieldModel> Post(RingCentral.CustomFieldCreateRequest customFieldCreateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CustomFieldModel>(this.Path(false), customFieldCreateRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Updates custom field by ID specified in path.
        /// HTTP Method: put
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.CustomFieldModel> Put(RingCentral.CustomFieldUpdateRequest customFieldUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (fieldId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(fieldId));
            }
            return await rc.Put<RingCentral.CustomFieldModel>(this.Path(), customFieldUpdateRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Deletes custom field(s) by ID(s) with the corresponding values.
        /// HTTP Method: delete
        /// Endpoint: /restapi/{apiVersion}/account/{accountId}/custom-fields/{fieldId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (fieldId == null)
            {
                throw new System.ArgumentException("Parameter cannot be null", nameof(fieldId));
            }
            return await rc.Delete<string>(this.Path(), null, null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account
{
    public partial class Index
    {
        public Restapi.Account.CustomFields.Index CustomFields(string fieldId = null)
        {
            return new Restapi.Account.CustomFields.Index(this, fieldId);
        }
    }
}