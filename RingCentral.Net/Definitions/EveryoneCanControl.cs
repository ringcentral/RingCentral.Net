namespace RingCentral
{
    /// <summary>
    ///     Controls whether participants can start and pause recording
    /// </summary>
    public class EveryoneCanControl
    {
        /// <summary>
        ///     Controls whether preference is enabled
        ///     Example: true
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        ///     Describes whether preference is locked on Service Web
        /// </summary>
        public bool? locked { get; set; }
    }
}