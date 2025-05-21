namespace RingCentral
{
    /// <summary>
    ///     Query parameters for operation listStandardUserRole
    /// </summary>
    public class ListStandardUserRoleParameters
    {
        /// <summary>
        ///     Internal identifier of a service plan.
        /// </summary>
        public string servicePlanId { get; set; }

        /// <summary>
        ///     The result set page number (1-indexed) to return
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 1
        ///     Default: 1
        /// </summary>
        public long? page { get; set; }

        /// <summary>
        ///     The number of items per page. If provided value in the request
        ///     is greater than a maximum, the maximum value is applied
        ///     Maximum: 1000
        ///     Minimum: 1
        ///     Format: int32
        ///     Example: 100
        ///     Default: 100
        /// </summary>
        public long? perPage { get; set; }

        /// <summary>
        ///     Specifies whether to return advanced permissions capabilities within `permissionsCapabilities` resource.
        ///     The default value is false
        /// </summary>
        public bool? advancedPermissions { get; set; }
    }
}