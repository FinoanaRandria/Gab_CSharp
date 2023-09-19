using System;
using System.Collections.Generic;

namespace dabProject.Database
{
    public partial class Account
    {
        public Account()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int AccountId { get; set; }
        public int? ClientId { get; set; }
        public string Label { get; set; } = null!;
        public long Solde { get; set; }
        public string Pin { get; set; } = null!;
        public DateTime Creation { get; set; }
        public DateTime Expiration { get; set; }
        public bool Status { get; set; }
        public int? Tentative { get; set; }
        public string? CarteNumber { get; set; }

        public virtual Client? Client { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
