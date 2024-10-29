using System.Diagnostics.Contracts;
using System.Transactions;

namespace SpendingTracker.Api.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
