namespace RingCentral
{
    public class DevicesSearchOrderBy
    {
        /// <summary>
        ///     The sorting field name
        ///     Enum: name, phoneNumber, serial, extensionName, site, orderStatus, extensionNumber
        /// </summary>
        public string fieldName { get; set; }

        /// <summary>
        ///     Default: ASC
        ///     Enum: ASC, DESC
        /// </summary>
        public string direction { get; set; }
    }
}