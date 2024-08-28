namespace Contrato.Entities
{
    public class Installment // Parcelas
    {
        public DateOnly dueDate { get; set; } // Data vencimento
        public double amount { get; set; } // Valor

        public Installment(DateOnly dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{dueDate} - {amount}";
        }
    }
}
