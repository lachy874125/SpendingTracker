namespace SpendingTracker.Api.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        // Foreign key for bank account
        public int BankAcountId { get; set; }
        public BankAccount BankAccount { get; set; }

        // Foreign key for Category
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
