namespace RingCentral
{
    public class UpdateBridgeRequest
    {
        /// <summary>
        ///     Custom name of a bridge
        ///     Example: Weekly Meeting with Joseph
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// </summary>
        public BridgePinsWithoutPstn pins { get; set; }

        /// <summary>
        /// </summary>
        public BridgeRequestSecurity security { get; set; }

        /// <summary>
        /// </summary>
        public BridgePreferences preferences { get; set; }
    }
}