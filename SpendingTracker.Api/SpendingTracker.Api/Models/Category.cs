namespace SpendingTracker.Api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for related transactions
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
