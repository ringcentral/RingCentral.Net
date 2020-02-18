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
        /// Operation: Create Custom Field
        /// Http Post /restapi/v1.0/account/{accountId}/custom-fields
        /// </summary>
        public async Task<RingCentral.CustomFieldResource> Post(
            RingCentral.CustomFieldCreateRequest customFieldCreateRequest)
        {
            return await rc.Post<RingCentral.CustomFieldResource>(this.Path(false), customFieldCreateRequest);
        }

        /// <summary>
        /// Operation: Get Custom Field List
        /// Http Get /restapi/v1.0/account/{accountId}/custom-fields
        /// </summary>
        public async Task<RingCentral.CustomFieldsResource> Get()
        {
            return await rc.Get<RingCentral.CustomFieldsResource>(this.Path(false));
        }

        /// <summary>
        /// Operation: Update Сustom Field
        /// Http Put /restapi/v1.0/account/{accountId}/custom-fields/{fieldId}
        /// </summary>
        public async Task<RingCentral.CustomFieldResource> Put(
            RingCentral.CustomFieldUpdateRequest customFieldUpdateRequest)
        {
            if (this.fieldId == null)
            {
                throw new System.ArgumentNullException("fieldId");
            }

            return await rc.Put<RingCentral.CustomFieldResource>(this.Path(), customFieldUpdateRequest);
        }

        /// <summary>
        /// Operation: Delete Custom Field
        /// Http Delete /restapi/v1.0/account/{accountId}/custom-fields/{fieldId}
        /// </summary>
        public async Task<string> Delete()
        {
            if (this.fieldId == null)
            {
                throw new System.ArgumentNullException("fieldId");
            }

            return await rc.Delete<string>(this.Path());
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