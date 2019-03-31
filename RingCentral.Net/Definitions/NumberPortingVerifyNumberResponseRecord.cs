namespace RingCentral
{
    public class NumberPortingVerifyNumberResponseRecord
    {
        /* The verified phone number. */
        public string phoneNumber;

        /* Is phone number billing phone number or not. */
        public bool? isBillingNumber;

        /* The result of phone number validation, can or not be ported the phone number. */
        // Enum: Success, Failure
        public string validationStatus;

        /* The reason why the corresponding phone number can`t be ported. */
        public string reason;
    }
}