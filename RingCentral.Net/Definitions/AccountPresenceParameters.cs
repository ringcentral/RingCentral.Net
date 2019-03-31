namespace RingCentral
{
    public class AccountPresenceParameters
    {
        /* Whether to return detailed telephony state */
        public bool? detailedTelephonyState;

        /* Whether to return SIP data */
        public bool? sipData;

        /* Page number for account presence information */
        public long? page;

        /* Number for account presence information items per page */
        public long? perPage;
    }
}