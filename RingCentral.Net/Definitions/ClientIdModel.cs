namespace RingCentral
{
    public class ClientIdModel
    {
        /// <summary>
        ///     The registered identifier of a client application.
        ///     Used to identify a client ONLY if the client authentication is not required and
        ///     corresponding credentials are not provided with this request
        ///     Example: AZwEVwGEcfGet2PCouA7K6
        /// </summary>
        public string client_id { get; set; }
    }
}