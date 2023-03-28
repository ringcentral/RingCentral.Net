namespace RingCentral
{
    public class BridgePins
    {
        /// <summary>
        /// </summary>
        public BridgePstnPins pstn { get; set; }

        /// <summary>
        ///     Bridge short identifier (Web PIN). The digital unique code which is used to join to a meeting. If it is not
        ///     specified
        ///     while creation, then a code will be generated. If it is a default bridge, then this code is
        ///     Personal Meeting Identifier (PMI).
        ///     NOTE: Changing this PIN via update method is deprecated. So to change Web PIN use the method:
        ///     _*[PATCH] /rcvideo/v2/bridges/{bridgeId}/pin/web*_
        ///     Example: 018209241352
        /// </summary>
        public string web { get; set; }
    }
}