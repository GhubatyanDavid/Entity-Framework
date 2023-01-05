using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Infrastructure.Entities
{
    public partial class Ship
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public short? Launched { get; set; }

        public virtual Classes ClassNavigation { get; set; }
    }
}
