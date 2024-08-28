namespace Contrato.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount) 
        {
            return amount+=(amount * 0.02);
        }

        public double Interest(double amount, int month)
        {
            return amount += ((amount/100)*month);
        }
    }
}
