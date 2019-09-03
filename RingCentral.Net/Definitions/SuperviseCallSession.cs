namespace RingCentral
{
    public class SuperviseCallSession
    {
        /// <summary>
        /// Information about a call party that monitors a call
        /// </summary>
        public PartyInfo from;

        /// <summary>
        /// Information about a call party that is monitored
        /// </summary>
        public PartyInfo to;

        /// <summary>
        /// Direction of a call
        /// Enum: Outbound, Inbound
        /// </summary>
        public string direction;

        /// <summary>
        /// Internal identifier of a party that monitors a call
        /// </summary>
        public string id;

        /// <summary>
        /// Specifies if a call participant is muted or not. **Note:** If a call is also controlled via Hard phone or RingCentral App (not only through the API by calling call control methods) then it cannot be fully muted/unmuted via API only, in this case the action should be duplicated via Hard phone/RC App interfaces
        /// </summary>
        public bool? muted;

        /// <summary>
        /// Data on a call owner
        /// </summary>
        public OwnerInfo owner;

        /// <summary>
        /// If 'True' then the party is not connected to a session voice conference, 'False' means the party is connected to other parties in a session
        /// </summary>
        public bool? standAlone;

        /// <summary>
        /// </summary>
        public CallStatusInfo status;
    }
}