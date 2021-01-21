namespace RingCentral
{
    public class TransferTarget
    {
        /// <summary>
        /// Phone number
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        /// Voicemail owner extension identifier
        /// </summary>
        public string voicemail { get; set; }

        /// <summary>
        /// Park orbit identifier
        /// </summary>
        public string parkOrbit { get; set; }
    }
}