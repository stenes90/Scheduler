//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulerV3.RankedinTestDb
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlayerRacquet
    {
        public int Id { get; set; }
        public int RacquetId { get; set; }
        public int PlayerId { get; set; }
        public System.DateTime StartsUsing { get; set; }
        public bool Active { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Racquet Racquet { get; set; }
    }
}
