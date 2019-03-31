namespace RingCentral
{
    public class PartyUpdateInfo
    {
        /// <summary>
        /// True if the party is muted. False - otherwise
        /// </summary>
        public bool? muted;

        /// <summary>
        /// True if party is not connected to a session voice conference. False - otherwise
        /// </summary>
        public bool? standAlone;
    }
}