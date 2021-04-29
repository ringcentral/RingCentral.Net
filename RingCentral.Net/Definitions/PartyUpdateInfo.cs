namespace RingCentral
{
    // Party update data
    public class PartyUpdateInfo
    {
        /// <summary>
        ///     Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted { get; set; }

        /// <summary>
        ///     If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone { get; set; }
    }
}