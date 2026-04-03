namespace RingCentral
{
    public class CommStateUpdateRequest
    {
        /// <summary>
        ///     Specifies if a state is enabled or not. *Work Hours* and *After Hours* states cannot be disabled
        /// </summary>
        public bool? enabled { get; set; }

        /// <summary>
        /// </summary>
        public object[] conditions { get; set; }
    }
}