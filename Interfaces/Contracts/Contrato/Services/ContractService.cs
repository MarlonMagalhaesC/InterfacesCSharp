using Contrato.Entities;

namespace Contrato.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double amount;

            for (int i = 1; i <= months; i++)
            {
                amount = _onlinePaymentService.PaymentFee(_onlinePaymentService.Interest(contract.totalValue / months, i));
                Installment installment = new Installment(contract.date.AddMonths(i), amount);
                contract.installments.Add(installment);

                // contract.installments.Add(new Installment(contract.date.AddMonths(i),onlinePaymentService.PaymentFee(onlinePaymentService.Interest(contract.totalValue/months, i))));
            }


            foreach (Installment i in contract.installments)
                Console.WriteLine(i);
        }
    }
}
