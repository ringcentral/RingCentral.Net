namespace RingCentral
{
    public class GetCallRecordsParameters
    {
        // View of call records. The same view parameter specified for FSync will be applied for ISync, the view cannot be changed for ISync
        // Default: Simple
        // Enum: Simple, Detailed
        public string view;
    }
}