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
    
    public partial class TeamLeagueTeamLineup
    {
        public int Id { get; set; }
        public int TeamMatchId { get; set; }
        public int TeamLeagueTeamId { get; set; }
        public int DivisionMatchSettingsId { get; set; }
        public int LineupNumber { get; set; }
        public int TeamParticipant1Id { get; set; }
        public Nullable<int> TeamParticipant2Id { get; set; }
    
        public virtual DivisionMatchSetting DivisionMatchSetting { get; set; }
        public virtual TeamLeagueTeam TeamLeagueTeam { get; set; }
        public virtual TeamMatch TeamMatch { get; set; }
    }
}
