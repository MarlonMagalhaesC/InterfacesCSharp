using Contrato.Entities;
using Contrato.Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                Console.Write("Contract value: ");
                double totalValue = double.Parse(Console.ReadLine());

                Console.Write("Enter number of installments: ");
                int months = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, date, totalValue);

                ContractService contractService = new ContractService(new PaypalService());
                contractService.ProcessContract(contract, months);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}