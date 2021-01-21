using Newtonsoft.Json;

namespace RingCentral
{
    public class UserResponse
    {
        /// <summary>
        /// user status
        /// </summary>
        public bool? active { get; set; }

        /// <summary>
        /// </summary>
        public UserAddress[] addresses { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public Email[] emails { get; set; }

        /// <summary>
        /// external unique resource id defined by provisioning client
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        /// unique resource id defined by RingCentral
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        public Name name { get; set; }

        /// <summary>
        /// </summary>
        public PhoneNumber[] phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public Photo[] photos { get; set; }

        /// <summary>
        /// Required
        /// Enum: urn:ietf:params:scim:schemas:core:2.0:User
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public EnterpriseUser urn_ietf_params_scim_schemas_extension_enterprise_2_0_User;

        /// <summary>
        /// MUST be same as work type email address
        /// Required
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// </summary>
        public Meta meta { get; set; }
    }
}