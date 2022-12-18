using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Printer
    {
        public int Code { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }

        public virtual Product ModelNavigation { get; set; }
    }
}
