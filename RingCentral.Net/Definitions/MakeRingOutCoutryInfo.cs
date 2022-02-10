namespace RingCentral
{
    /// <summary>
    ///     Optional. Dialing plan country data. If not specified, then extension home country is applied by default
    /// </summary>
    public class MakeRingOutCoutryInfo
    {
        /// <summary>
        ///     Dialing plan country identifier
        /// </summary>
        public string id { get; set; }
    }
}