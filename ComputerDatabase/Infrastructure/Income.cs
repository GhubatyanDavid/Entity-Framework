using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Income
    {
        public int Code { get; set; }
        public byte Point { get; set; }
        public DateTime Date { get; set; }
        public decimal Inc { get; set; }
    }
}
