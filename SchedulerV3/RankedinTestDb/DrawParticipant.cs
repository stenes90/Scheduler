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
    
    public partial class DrawParticipant
    {
        public int Id { get; set; }
        public int DrawId { get; set; }
        public int PositionHigh { get; set; }
        public int PositionLow { get; set; }
        public int SeedOrder { get; set; }
        public int DrawPosition { get; set; }
        public string ParticipantName { get; set; }
        public int EventParticipantId { get; set; }
        public bool IsQualifier { get; set; }
    
        public virtual EventParticipant EventParticipant { get; set; }
        public virtual TournamentDraw TournamentDraw { get; set; }
    }
}
