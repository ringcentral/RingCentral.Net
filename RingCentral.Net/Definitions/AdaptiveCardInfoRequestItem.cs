namespace RingCentral
{
    public class AdaptiveCardInfoRequestItem
    {
        /// <summary>
        ///     Enum: TextBlock, ColumnSet, Column, FactSet
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// </summary>
        public string weight { get; set; }

        /// <summary>
        /// </summary>
        public string size { get; set; }

        /// <summary>
        /// </summary>
        public AdaptiveCardColumnInfo[] columns { get; set; }
    }
}