namespace RingCentral
{
    public class OrderBy
    {
        /// <summary>
        /// Sorting priority index, starting from '1'. Optional if only one element in `orderBy` array is specified
        /// </summary>
        public long? index;

        /// <summary>
        /// Field name by which to sort the contacts
        /// Enum: firstName, lastName, extensionNumber, phoneNumber, email
        /// </summary>
        public string fieldName;

        /// <summary>
        /// Sorting direction
        /// Enum: Asc, Desc
        /// </summary>
        public string direction;
    }
}