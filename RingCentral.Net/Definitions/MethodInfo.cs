namespace RingCentral
{
    public class MethodInfo
    {
        /// <summary>
        /// Method identifier. The default value is 1 (Ground)
        /// Enum: 1, 2, 3
        /// </summary>
        public string id;

        /// <summary>
        /// Method name, corresponding to the identifier
        /// Enum: Ground, 2 Day, Overnight
        /// </summary>
        public string name;
    }
}