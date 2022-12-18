using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComputerDatabase
{
    public partial class Outcomes
    {
        public string Ship { get; set; }
        public string Battle { get; set; }
        public string Result { get; set; }

        public virtual Battles BattleNavigation { get; set; }
    }
}
