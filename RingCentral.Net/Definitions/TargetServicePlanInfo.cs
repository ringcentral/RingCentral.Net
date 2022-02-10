namespace RingCentral
{
    /// <summary>
    ///     Information on account target service plan
    /// </summary>
    public class TargetServicePlanInfo
    {
        /// <summary>
        ///     Internal identifier of a target service plan
        /// </summary>
        public string id { get; set; }

        /// <summary>
        ///     Name of a target service plan
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     Edition of a service plan
        /// </summary>
        public string edition { get; set; }

        /// <summary>
        ///     Enum: Freyja, Phoenix
        /// </summary>
        public string freemiumProductType { get; set; }
    }
}