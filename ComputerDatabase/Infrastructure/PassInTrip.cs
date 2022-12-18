using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class PassInTrip
    {
        public int TripNo { get; set; }
        public DateTime Date { get; set; }
        public int IdPsg { get; set; }
        public string Place { get; set; }

        public virtual Passenger IdPsgNavigation { get; set; }
        public virtual Trip TripNoNavigation { get; set; }
    }
}
