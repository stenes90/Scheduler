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
    
    public partial class DivisionMatchSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DivisionMatchSetting()
        {
            this.TeamLeagueTeamLineups = new HashSet<TeamLeagueTeamLineup>();
        }
    
        public int Id { get; set; }
        public int DivisionId { get; set; }
        public int AgeGroup { get; set; }
        public int MatchType { get; set; }
        public int MatchesCount { get; set; }
        public int SettingOrder { get; set; }
    
        public virtual TeamLeagueDivision TeamLeagueDivision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamLeagueTeamLineup> TeamLeagueTeamLineups { get; set; }
    }
}
