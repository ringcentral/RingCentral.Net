namespace RingCentral
{
    public class DelegateInfo
    {
        /// <summary>
        /// </summary>
        public DelegateExtensionInfo extension;

        /// <summary>
        /// Specifies whether Secretary is permitted to pickup calls on behalf of Boss
        /// </summary>
        public bool? callPickup;

        /// <summary>
        /// Specifies whether Secretary is permitted to organize conference on behalf of Boss
        /// </summary>
        public bool? conferencing;
    }
}