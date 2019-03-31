namespace RingCentral
{
    public class NumberPortingVerifyNumberResponseRecord
    {
        /// <summary>
        /// The verified phone number.
        /// </summary>
        public string phoneNumber;

        /// <summary>
        /// Is phone number billing phone number or not.
        /// </summary>
        public bool? isBillingNumber;

        /// <summary>
        /// The result of phone number validation, can or not be ported the phone number.
        /// Enum: Success, Failure
        /// </summary>
        public string validationStatus;

        /// <summary>
        /// The reason why the corresponding phone number can`t be ported.
        /// </summary>
        public string reason;
    }
}