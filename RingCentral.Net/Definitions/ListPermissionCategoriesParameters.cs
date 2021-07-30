namespace RingCentral
{
    // Query parameters for operation listPermissionCategories
    public class ListPermissionCategoriesParameters
    {
        /// <summary>
        ///     Default: 1
        /// </summary>
        public string page { get; set; }

        /// <summary>
        ///     Default: 100
        /// </summary>
        public string perPage { get; set; }

        /// <summary>
        /// </summary>
        public string servicePlanId { get; set; }
    }
}