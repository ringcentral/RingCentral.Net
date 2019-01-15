using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class UserResponse : Serializable
    {
        // user status
        public bool? active;
        public Address[] addresses;
        public Email[] emails;
        // external unique resource id defined by provisioning client
        public string externalId;
        // unique resource id defined by RingCentral
        public string id;
        public Name name;
        public PhoneNumber[] phoneNumbers;
        public Photo[] photos;
        public string[] schemas;
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public EnterpriseUser urn_ietf_params_scim_schemas_extension_enterprise_2_0_User;
        // MUST be same as work type email address
        public string userName;
        public Meta meta;
    }
}