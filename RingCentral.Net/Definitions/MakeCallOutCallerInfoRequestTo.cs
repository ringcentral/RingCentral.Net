namespace RingCentral
{
    /// <summary>
    ///     Phone number of the called party. This number corresponds to the 2nd leg of a CallOut call
    /// </summary>
    public class MakeCallOutCallerInfoRequestTo
    {
        /// <summary>
        ///     Phone number in E.164 format
        ///     Example: +16502223366
        /// </summary>
        public string phoneNumber { get; set; }

        /// <summary>
        ///     Extension number
        ///     Example: 103
        /// </summary>
        public string extensionNumber { get; set; }
    }
}