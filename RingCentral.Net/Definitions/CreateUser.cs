using Newtonsoft.Json;

namespace RingCentral
{
    public class CreateUser
    {
        /// <summary>
        /// User status
        /// </summary>
        public bool? active;

        /// <summary>
        /// </summary>
        public UserAddress[] addresses;

        /// <summary>
        /// Required
        /// </summary>
        public Email[] emails;

        /// <summary>
        /// external unique resource id defined by provisioning client
        /// </summary>
        public string externalId;

        /// <summary>
        /// Required
        /// </summary>
        public Name name;

        /// <summary>
        /// </summary>
        public PhoneNumber[] phoneNumbers;

        /// <summary>
        /// </summary>
        public Photo[] photos;

        /// <summary>
        /// Required
        /// </summary>
        public string[] schemas;

        /// <summary>
        /// </summary>
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public EnterpriseUser urn_ietf_params_scim_schemas_extension_enterprise_2_0_User;

        /// <summary>
        /// MUST be same as work type email address
        /// Required
        /// </summary>
        public string userName;
    }
}