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
    
    public partial class RoundRobinRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoundRobinRule()
        {
            this.RoundRobinRuleSettings = new HashSet<RoundRobinRuleSetting>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsForTeamMatches { get; set; }
        public bool IsForTeams { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoundRobinRuleSetting> RoundRobinRuleSettings { get; set; }
    }
}
