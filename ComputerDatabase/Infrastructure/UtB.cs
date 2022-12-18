using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class UtB
    {
        public DateTime BDatetime { get; set; }
        public int BQId { get; set; }
        public int BVId { get; set; }
        public byte BVol { get; set; }

        public virtual UtQ BQ { get; set; }
        public virtual UtV BV { get; set; }
    }
}
