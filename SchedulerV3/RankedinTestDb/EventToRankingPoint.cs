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
    
    public partial class EventToRankingPoint
    {
        public int Id { get; set; }
        public int EventPointId { get; set; }
        public int RankingPointId { get; set; }
    
        public virtual EventPoint EventPoint { get; set; }
        public virtual RankingPoint RankingPoint { get; set; }
    }
}
