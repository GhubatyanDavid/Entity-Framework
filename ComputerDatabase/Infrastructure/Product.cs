using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Product
    {
        public Product()
        {
            Laptop = new HashSet<Laptop>();
            Pc = new HashSet<Pc>();
            Printer = new HashSet<Printer>();
        }

        public string Maker { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Laptop> Laptop { get; set; }
        public virtual ICollection<Pc> Pc { get; set; }
        public virtual ICollection<Printer> Printer { get; set; }
    }
}
