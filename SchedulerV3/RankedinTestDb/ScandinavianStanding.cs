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
    
    public partial class ScandinavianStanding
    {
        public int Id { get; set; }
        public int ClubleagueId { get; set; }
        public int ParticipantId { get; set; }
        public int Standing { get; set; }
        public int Round { get; set; }
        public int Movement { get; set; }
    
        public virtual ClubLeague ClubLeague { get; set; }
        public virtual ClubLeagueParticipant ClubLeagueParticipant { get; set; }
    }
}
