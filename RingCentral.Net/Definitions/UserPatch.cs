namespace RingCentral
{
    public class UserPatch
    {
        /// <summary>
        /// patch operations list
        /// Required
        /// </summary>
        public PatchOperation[] Operations { get; set; }

        /// <summary>
        /// Required
        /// Enum: urn:ietf:params:scim:api:messages:2.0:PatchOp
        /// </summary>
        public string[] schemas { get; set; }
    }
}