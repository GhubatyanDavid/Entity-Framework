using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class UtQ
    {
        public UtQ()
        {
            UtB = new HashSet<UtB>();
        }

        public int QId { get; set; }
        public string QName { get; set; }

        public virtual ICollection<UtB> UtB { get; set; }
    }
}
