using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Company
    {
        public Company()
        {
            Trip = new HashSet<Trip>();
        }

        public int IdComp { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Trip> Trip { get; set; }
    }
}
