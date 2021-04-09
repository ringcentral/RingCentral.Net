namespace RingCentral
{
    // Information on account service plan
    public class ServicePlanInfo
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
        ///     Edition of a service plan
        /// </summary>
        public string edition { get; set; }

        /// <summary>
        ///     Enum: Freyja, Phoenix
        /// </summary>
        public string freemiumProductType { get; set; }
    }
}