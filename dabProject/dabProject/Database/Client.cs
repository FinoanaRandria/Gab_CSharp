using System;
using System.Collections.Generic;

namespace dabProject.Database
{
    public partial class Client
    {
        public Client()
        {
            Accounts = new HashSet<Account>();
        }

        public int ClentId { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Cin { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
