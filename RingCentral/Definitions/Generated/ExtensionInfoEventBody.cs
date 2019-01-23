namespace RingCentral
{
    public class ExtensionInfoEventBody : Serializable
    {
        // Internal identifier of an extension
        public string extensionId;
        // Type of extension info change
        // Enum: Update, Delete
        public string eventType;
        // Returned for 'Update' event type only. The possible values are: /nAccountInfo - change of account parameters/nExtensionInfo - change of contact info, service features, departments, status/nPhoneNumber - change of phone numbers/nRole - change of permissions/nProfileImage - change of profile image
        public string[] hints;
        // Internal identifier of a subscription owner extension
        public string ownerId;
    }
}