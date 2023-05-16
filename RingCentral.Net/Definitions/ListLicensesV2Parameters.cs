namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listLicensesV2
    /// </summary>
    public class ListLicensesV2Parameters
    {
        /// <summary>
        ///     Identifiers of cost centers to return licenses for
        /// </summary>
        public string[] costCenterIds { get; set; }
    }
}