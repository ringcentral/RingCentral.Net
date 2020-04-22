namespace RingCentral
{
    public class UserPatch
    {
        /// <summary>
        /// patch operations list
        /// Required
        /// </summary>
        public PatchOperation[] Operations;

        /// <summary>
        /// Required
        /// Enum: urn:ietf:params:scim:api:messages:2.0:PatchOp
        /// </summary>
        public string[] schemas;
    }
}