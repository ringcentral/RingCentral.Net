namespace RingCentral
{
    public class CallMonitoringExtensionUpdate
    {
        /* Only the following extension types are allowed: User, DigitalUser, VirtualUser, FaxUser, Limited */
        public string id;

        /* Set of call monitoring group permissions granted to the specified extension. In order to remove the specified extension from a call monitoring group use an empty value */
        public string[] permissions;
    }
}