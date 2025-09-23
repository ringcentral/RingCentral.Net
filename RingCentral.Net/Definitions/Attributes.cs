namespace RingCentral
{
    public class Attributes
    {
        /// <summary>
        ///     Indicates that this party is agent of new call queue
        /// </summary>
        public bool? queueCall { get; set; }

        /// <summary>
        ///     Indicates that it was emergency ringback to party
        /// </summary>
        public bool? emergencyCallback { get; set; }
    }
}