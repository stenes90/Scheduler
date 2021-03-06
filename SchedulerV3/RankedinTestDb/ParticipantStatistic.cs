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
    
    public partial class ParticipantStatistic
    {
        public int Id { get; set; }
        public int CurrentYearHighestRankingSingles { get; set; }
        public int CurrentYearCurrentRankingSingles { get; set; }
        public int CurrentYearWinsSingles { get; set; }
        public int CurrentYearLosesSingles { get; set; }
        public int CurrentYearEventParticipationsSingles { get; set; }
        public int CareerHighestRankingSingles { get; set; }
        public System.DateTime CareerHighestRankingDateSingles { get; set; }
        public int CareerEventParticipationsSingles { get; set; }
        public int CareerWinsSingles { get; set; }
        public int CareerLosesSingles { get; set; }
        public string Form { get; set; }
        public int CurrentYearHighestRankingDoubles { get; set; }
        public int CurrentYearCurrentRankingDoubles { get; set; }
        public int CurrentYearWinsDoubles { get; set; }
        public int CurrentYearLosesDoubles { get; set; }
        public int CurrentYearEventParticipationsDoubles { get; set; }
        public int CareerHighestRankingDoubles { get; set; }
        public System.DateTime CareerHighestRankingDateDoubles { get; set; }
        public int CareerEventParticipationsDoubles { get; set; }
        public int CareerWinsDoubles { get; set; }
        public int CareerLosesDoubles { get; set; }
        public int ParticipantId { get; set; }
    
        public virtual Participant Participant { get; set; }
    }
}
