using Newtonsoft.Json;

namespace RingCentral.Net
{
    public class OrderBy : Serializable
    {
        // Sorting priority index, starting from '1'. Optional if only one element in `orderBy` array is specified
        public long? index;
        // Field name by which to sort the contacts
        // Enum: firstName, lastName, extensionNumber, phoneNumber, email
        public string fieldName;
        // Sorting direction
        // Enum: Asc, Desc
        public string direction;
    }
}