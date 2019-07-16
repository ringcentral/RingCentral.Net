namespace RingCentral
{
    public class PartyUpdateInfo
    {
        /// <summary>
        /// If 'True' the party is muted
        /// </summary>
        public bool? muted;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;
    }
}