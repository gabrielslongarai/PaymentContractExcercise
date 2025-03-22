
using PaymentContractExcercise.Entities;

namespace PaymentContractExcercise.Services
{
    interface IPaymentService
    {
        public double MonthlyInterest(double amount, int months);

        public double PaymentFee(double amount);
    }
}
