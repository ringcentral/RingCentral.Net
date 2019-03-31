namespace RingCentral
{
    public class NumberPortingVerifyNumberRequestRecord
    {
        /// <summary>
        /// Phone number to verify
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Is phone number billing phone number or not. Can be specified for one phone number only.
        /// </summary>
        public bool? isBillingNumber;
    }
}