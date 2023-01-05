using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Infrastructure.Entities
{
    public partial class Trip
    {
        public Trip()
        {
            PassInTrip = new HashSet<PassInTrip>();
        }

        public int TripNo { get; set; }
        public int IdComp { get; set; }
        public string Plane { get; set; }
        public string TownFrom { get; set; }
        public string TownTo { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime TimeIn { get; set; }

        public virtual Company IdCompNavigation { get; set; }
        public virtual ICollection<PassInTrip> PassInTrip { get; set; }
    }
}
