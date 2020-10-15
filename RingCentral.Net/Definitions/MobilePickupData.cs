namespace RingCentral
{
    public class MobilePickupData
    {
        /// <summary>
        /// The list of extension IDs, configured to pick a call from Desktop/Mobile applications
        /// </summary>
        public string[] ccMailboxes;

        /// <summary>
        /// SIP proxy registration name
        /// </summary>
        public string to;

        /// <summary>
        /// User data
        /// </summary>
        public string sid;

        /// <summary>
        /// User data
        /// </summary>
        public string srvlvl;

        /// <summary>
        /// User data
        /// </summary>
        public string srvLvlExt;
    }
}