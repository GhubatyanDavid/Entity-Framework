using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Infrastructure.Entities
{
    public partial class IncomeO
    {
        public byte Point { get; set; }
        public DateTime Date { get; set; }
        public decimal Inc { get; set; }
    }
}
