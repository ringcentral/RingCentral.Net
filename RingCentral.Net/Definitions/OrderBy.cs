namespace RingCentral
{
    public class OrderBy
    {
        /// <summary>
        ///     Sorting priority index, starting from '1'. Optional if only one element in `orderBy` array is specified
        ///     Format: int32
        /// </summary>
        public long? index { get; set; }

        /// <summary>
        ///     Field name by which to sort the contacts
        ///     Enum: firstName, lastName, extensionNumber, phoneNumber, email, jobTitle, department
        /// </summary>
        public string fieldName { get; set; }

        /// <summary>
        ///     Sorting direction
        ///     Enum: Asc, Desc
        /// </summary>
        public string direction { get; set; }
    }
}