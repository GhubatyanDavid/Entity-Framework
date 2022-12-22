using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Classes
    {
        public Classes()
        {
            Ships = new HashSet<Ship>();
        }

        public string Class { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public byte? NumGuns { get; set; }
        public float? Bore { get; set; }
        public int? Displacement { get; set; }

        public virtual ICollection<Ship> Ships { get; set; }
    }
}
