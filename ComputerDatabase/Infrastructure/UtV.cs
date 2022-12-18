using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class UtV
    {
        public UtV()
        {
            UtB = new HashSet<UtB>();
        }

        public int VId { get; set; }
        public string VName { get; set; }
        public string VColor { get; set; }

        public virtual ICollection<UtB> UtB { get; set; }
    }
}
