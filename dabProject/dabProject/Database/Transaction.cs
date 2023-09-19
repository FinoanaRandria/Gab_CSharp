using System;
using System.Collections.Generic;

namespace dabProject.Database
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int SoldeAvant { get; set; }
        public DateTime DateDeLaTransaction { get; set; }
        public int SoldeApres { get; set; }
        public string Type { get; set; } = null!;
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
