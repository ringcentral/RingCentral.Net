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
        /// </summary>
        public string[] schemas;
    }
}