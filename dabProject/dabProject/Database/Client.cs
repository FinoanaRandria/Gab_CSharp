using System;
using System.Collections.Generic;

namespace dabProject.Database
{
    public partial class Client
    {
        public int ClentId { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Adresse { get; set; } = null!;
        public string Cin { get; set; } = null!;
        public int AccountId { get; set; }

        public virtual Account Account { get; set; } = null!;
    }
}
