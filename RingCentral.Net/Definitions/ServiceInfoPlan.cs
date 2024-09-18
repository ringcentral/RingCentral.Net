namespace RingCentral
{
    /// <summary>
    ///     Information on account service plan
    /// </summary>
    public class ServiceInfoPlan
    {
        /// <summary>
        ///     Internal identifier of a service plan
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a service plan
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Enum: Freyja, Phoenix
        /// </summary>
        public string freemiumProductType { get; set; }
    }
}