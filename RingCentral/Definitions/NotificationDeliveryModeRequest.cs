namespace RingCentral
{
    public class NotificationDeliveryModeRequest
    {
        public string transportType;
        public string address;
        public bool? encryption;
        public string certificateName;
        public string registrationId;
        public string verificationToken;
    }
}
