namespace RingCentral
{
    public class SwitchValidated
    {
        /// <summary>
        /// Internal identifier of a switch
        /// </summary>
        public string id;

        /// <summary>
        /// Unique identifier of a network switch
        /// </summary>
        public string chassisId;

        /// <summary>
        /// Validation result status
        /// Enum: Valid, Invalid
        /// </summary>
        public string status;

        /// <summary>
        /// </summary>
        public ValidationError[] errors;
    }
}