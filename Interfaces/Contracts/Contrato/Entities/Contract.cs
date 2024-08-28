namespace Contrato.Entities
{
    public class Contract
    {
        public int number { get; set; }
        public DateOnly date { get; set; }
        public double totalValue { get; set; }

        public List<Installment> installments;

        public Contract(int number, DateOnly date, double totalValue)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            installments = new List<Installment>();
        }



    }
}
