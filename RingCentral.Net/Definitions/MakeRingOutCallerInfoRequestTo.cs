namespace RingCentral
{
    /// <summary>
    ///     Phone number of the called party. This number corresponds to the 2nd leg of the RingOut call
    /// </summary>
    public class MakeRingOutCallerInfoRequestTo
    {
        /// <summary>
        ///     Phone number in E.164 format
        /// </summary>
        public string phoneNumber { get; set; }
    }
}