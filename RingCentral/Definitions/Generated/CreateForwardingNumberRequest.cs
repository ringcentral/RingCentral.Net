namespace RingCentral
{
    public class CreateForwardingNumberRequest : Serializable
    {
        // Forwarding/Call flip phone number
        public string phoneNumber;

        // Forwarding/Call flip number title
        public string label;

        // Forwarding/Call flip phone type. If specified, 'label' attribute value is ignored. The default value is 'Other'
        // Enum: PhoneLine, Home, Mobile, Work, Other
        public string type;

        // Reference to the other extension device. Applicable for 'PhoneLine' type only. Cannot be specified together with 'phoneNumber' parameter.
        public CreateForwardingNumberDeviceInfo device;
    }
}