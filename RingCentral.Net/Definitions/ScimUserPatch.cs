namespace RingCentral
{
    public class ScimUserPatch
    {
        /// <summary>
        ///     Patch operations list
        ///     Required
        /// </summary>
        public ScimPatchOperation[] Operations { get; set; }

        /// <summary>
        ///     Required
        ///     Enum: urn:ietf:params:scim:api:messages:2.0:PatchOp
        /// </summary>
        public string[] schemas { get; set; }
    }
}