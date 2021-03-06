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
    
    public partial class Challenge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Challenge()
        {
            this.TeamMatchMatches = new HashSet<TeamMatchMatch>();
            this.TournamentMatches = new HashSet<TournamentMatch>();
        }
    
        public int c_id { get; set; }
        public int c_challenger { get; set; }
        public int c_challenged { get; set; }
        public int c_match { get; set; }
        public int c_state { get; set; }
        public int c_eventtype { get; set; }
        public int c_event { get; set; }
        public Nullable<int> c_requested { get; set; }
        public Nullable<int> ScoreRuleId { get; set; }
        public Nullable<int> ChatId { get; set; }
    
        public virtual Chat Chat { get; set; }
        public virtual Match Match { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamMatchMatch> TeamMatchMatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TournamentMatch> TournamentMatches { get; set; }
    }
}
