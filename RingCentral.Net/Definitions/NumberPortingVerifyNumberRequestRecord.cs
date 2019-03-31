namespace RingCentral
{
    public class NumberPortingVerifyNumberRequestRecord
    {
        /* Phone number to verify */
        public string phoneNumber;

        /* Is phone number billing phone number or not. Can be specified for one phone number only. */
        public bool? isBillingNumber;
    }
}