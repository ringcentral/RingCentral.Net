namespace RingCentral
{
    public class ReplyParty
    {
        /// <summary>
        /// Internal identifier of a party
        /// </summary>
        public string id;

        /// <summary>
        /// Status data of a call session
        /// </summary>
        public CallStatusInfo status;

        /// <summary>
        /// Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// Call park information
        /// </summary>
        public ParkInfo park;

        /// <summary>
        /// Data on a calling party
        /// </summary>
        public PartyInfo from;

        /// <summary>
        /// Data on a called party
        /// </summary>
        public PartyInfo to;

        /// <summary>
        /// Data on a call owner
        /// </summary>
        public OwnerInfo owner;

        /// <summary>
        /// Direction of a call
        /// Enum: Inbound, Outbound
        /// </summary>
        public string direction;
    }
}