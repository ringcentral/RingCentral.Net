namespace RingCentral
{
    public class DelegateInfo
    {
        /// <summary>
        /// </summary>
        public DelegateExtensionInfo extension { get; set; }

        /// <summary>
        ///     Specifies whether secretary user is permitted to pickup calls on behalf of boss user role
        /// </summary>
        public bool? callPickup { get; set; }

        /// <summary>
        ///     Specifies whether secretary user is permitted to organize conference on behalf of boss user role
        /// </summary>
        public bool? conferencing { get; set; }

        /// <summary>
        /// </summary>
        public ConferencingSettingsInfo conferencingSettings { get; set; }

        /// <summary>
        ///     List of the delegate users for the current boss user
        /// </summary>
        public string[] delegateIds { get; set; }
    }
}