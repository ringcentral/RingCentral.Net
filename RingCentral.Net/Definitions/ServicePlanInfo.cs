namespace RingCentral
{
    // Information on account service plan
    public class ServicePlanInfo
    {
        /// <summary>
        /// Internal identifier of a service plan
        /// </summary>
        public string id;

        /// <summary>
        /// Name of a service plan
        /// </summary>
        public string name;

        /// <summary>
        /// Edition of a service plan
        /// </summary>
        public string edition;

        /// <summary>
        /// Enum: Freyja, Phoenix
        /// </summary>
        public string freemiumProductType;
    }
}