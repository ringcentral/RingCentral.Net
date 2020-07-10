namespace RingCentral
{
    public class BridgeTargetRequest
    {
        /// <summary>
        /// Internal identifier of a call session to be connected to (bridged)
        /// Required
        /// </summary>
        public string telephonySessionId;

        /// <summary>
        /// Internal identifier of a call party to be connected to (bridged)
        /// Required
        /// </summary>
        public string partyId;
    }
}