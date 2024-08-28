namespace Contrato.Services
{
    public interface IOnlinePaymentService
    {
        public double PaymentFee(double amount); //Juros
        public double Interest(double amount, int months); //Lucro
    }
}
