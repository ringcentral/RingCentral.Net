using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.CustomFields
{
    public partial class Index
    {
        public RestClient rc;
        public string fieldId;
        public Restapi.Account.Index parent;

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
        /// Operation: Get Custom Field List
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/custom-fields
        /// Rate Limit Group: Light
        /// App Permission: ReadAccounts
        /// User Permission: ReadUserInfo
        /// </summary>
        public async Task<RingCentral.CustomFieldsResource> Get(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.CustomFieldsResource>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Custom Field
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/custom-fields
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.CustomFieldResource> Post(
            RingCentral.CustomFieldCreateRequest customFieldCreateRequest, RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.CustomFieldResource>(this.Path(false), customFieldCreateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Сustom Field
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/custom-fields/{fieldId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<RingCentral.CustomFieldResource> Put(
            RingCentral.CustomFieldUpdateRequest customFieldUpdateRequest, RestRequestConfig restRequestConfig = null)
        {
            if (this.fieldId == null)
            {
                throw new System.ArgumentNullException("fieldId");
            }

            return await rc.Put<RingCentral.CustomFieldResource>(this.Path(), customFieldUpdateRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Custom Field
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/custom-fields/{fieldId}
        /// Rate Limit Group: Light
        /// App Permission: EditAccounts
        /// User Permission: Users
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.fieldId == null)
            {
                throw new System.ArgumentNullException("fieldId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
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