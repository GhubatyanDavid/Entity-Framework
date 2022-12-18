using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Battles
    {
        public Battles()
        {
            Outcomes = new HashSet<Outcomes>();
        }

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Outcomes> Outcomes { get; set; }
    }
}
