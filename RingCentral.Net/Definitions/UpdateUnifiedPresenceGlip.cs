namespace RingCentral
{
    public class UpdateUnifiedPresenceGlip
    {
        /// <summary>
        /// Visibility setting allowing other users to see Glip presence status
        /// Enum: Visible, Invisible
        /// </summary>
        public string visibility { get; set; }

        /// <summary>
        /// Availability setting specifing whether to receive Glip notifications or not
        /// Enum: Available, DND
        /// </summary>
        public string availability { get; set; }
    }
}