namespace RingCentral
{
    public class DelegateInfo
    {
        /// <summary>
        /// </summary>
        public DelegateExtensionInfo extension { get; set; }

        /// <summary>
        /// Specifies whether Secretary is permitted to pickup calls on behalf of Boss
        /// </summary>
        public bool? callPickup { get; set; }

        /// <summary>
        /// Specifies whether Secretary is permitted to organize conference on behalf of Boss
        /// </summary>
        public bool? conferencing { get; set; }
    }
}