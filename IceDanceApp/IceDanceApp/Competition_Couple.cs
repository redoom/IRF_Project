//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IceDanceApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Competition_Couple
    {
        public int SeasonEventSK { get; set; }
        public Nullable<int> CoupleFK { get; set; }
        public Nullable<int> CompetitionFK { get; set; }
        public Nullable<int> Rank { get; set; }
    
        public virtual Competition Competition { get; set; }
        public virtual Couple Couple { get; set; }
    }
}
