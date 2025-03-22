using PaymentContractExcercise.Entities;

namespace PaymentContractExcercise.Services
{
    class PaypalPaymentService : IPaymentService
    {
        public double MonthlyInterest(double amount, int months)
        {
            return amount + (0.01 * months) ;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
