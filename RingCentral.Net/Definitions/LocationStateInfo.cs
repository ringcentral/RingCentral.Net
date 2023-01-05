namespace RingCentral
{
    /// <summary>
    ///     Information on a state this location belongs to
    /// </summary>
    public class LocationStateInfo
    {
        /// <summary>
        ///     Internal identifier of a state
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Link to a state resource
        ///     Format: uri
        /// </summary>
        public string uri { get; set; }
    }
}