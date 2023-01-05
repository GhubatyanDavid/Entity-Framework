using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Infrastructure.Entities
{

    public partial class Laptop
    {
        public int Code { get; set; }
        public string? Model { get; set; }
        public short Speed { get; set; }
        public short Ram { get; set; }
        public float Hd { get; set; }
        public decimal? Price { get; set; }
        public byte Screen { get; set; }

        public virtual Product? ModelNavigation { get; set; }
    }
}
