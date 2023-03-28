namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation deleteCustomRole
    /// </summary>
    public class DeleteCustomRoleParameters
    {
        /// <summary>
        ///     Specifies that role should be validated prior to deletion, whether
        ///     it can be deleted or not
        /// </summary>
        public bool? validateOnly { get; set; }
    }
}