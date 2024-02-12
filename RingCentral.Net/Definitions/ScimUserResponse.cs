using Newtonsoft.Json;

namespace RingCentral
{
    public class ScimUserResponse
    {
        /// <summary>
        /// </summary>
        [JsonProperty("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public ScimEnterpriseUser urn_ietf_params_scim_schemas_extension_enterprise_2_0_User;

        /// <summary>
        ///     User status
        /// </summary>
        public bool? active { get; set; }

        /// <summary>
        /// </summary>
        public ScimUserAddress[] addresses { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ScimEmail[] emails { get; set; }

        /// <summary>
        ///     External unique resource ID defined by provisioning client
        /// </summary>
        public string externalId { get; set; }

        /// <summary>
        ///     Unique resource ID defined by RingCentral
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Required
        /// </summary>
        public ScimName name { get; set; }

        /// <summary>
        /// </summary>
        public ScimPhoneNumber[] phoneNumbers { get; set; }

        /// <summary>
        /// </summary>
        public ScimPhoto[] photos { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: urn:ietf:params:scim:schemas:core:2.0:User
        /// </summary>
        public string[] schemas { get; set; }

        /// <summary>
        ///     User title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        ///     MUST be same as work type email address
        ///     Required
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// </summary>
        public ScimMeta meta { get; set; }
    }
}