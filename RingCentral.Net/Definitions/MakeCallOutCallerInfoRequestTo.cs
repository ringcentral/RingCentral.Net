namespace RingCentral
{
    /// <summary>
    ///     Phone number of the called party. This number corresponds to the 2nd leg of a CallOut call
    /// </summary>
    public class MakeCallOutCallerInfoRequestTo
    {
        /// <summary>
        ///     Phone number in E.164 format, short codes (*67, *86), emergency (911, 112) or special (988) numbers
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