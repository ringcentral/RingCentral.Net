namespace RingCentral
{
    public class CommIntegrationResource
    {
        /// <summary>
        ///     Phone number in [E.164](https://www.itu.int/rec/T-REC-E.164-201011-I) format
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Integration type
        ///     Required
        ///     Enum: MsTeamsDirectRouting, FmcLite
        /// </summary>
        public string type { get; set; }
    }
}