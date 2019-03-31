namespace RingCentral
{
    public class ReferenceInfo
    {
        /* Non-RC identifier of an extension */
        public string @ref;

        /* Type of external identifier */
        // Enum: PartnerId, CustomerDirectoryId
        public string type;
    }
}