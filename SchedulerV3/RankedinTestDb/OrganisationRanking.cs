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
    
    public partial class OrganisationRanking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganisationRanking()
        {
            this.ClubLeagues = new HashSet<ClubLeague>();
            this.EventPoints = new HashSet<EventPoint>();
            this.RankingEvents = new HashSet<RankingEvent>();
            this.RankingLevels = new HashSet<RankingLevel>();
            this.RankingParticipants = new HashSet<RankingParticipant>();
            this.TeamLeagueRankingLevels = new HashSet<TeamLeagueRankingLevel>();
            this.Tournaments = new HashSet<Tournament>();
        }
    
        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public bool AllowPrivateChallenges { get; set; }
        public int PrivacyPolicy { get; set; }
        public System.DateTime DateCreatedUTC { get; set; }
        public int SportId { get; set; }
        public Nullable<int> BestAmountOfTournamentClasses { get; set; }
        public bool IsLicenseRequired { get; set; }
        public Nullable<int> BestAmountOfClubLeagues { get; set; }
        public Nullable<int> BestAmountOfTeamLeagues { get; set; }
        public Nullable<int> PointsExpirationPeriodInMonths { get; set; }
        public int CalculationDay { get; set; }
        public System.TimeSpan CalculationTimeUTC { get; set; }
        public Nullable<int> BestAmountOfPrivateChallengesForMonth { get; set; }
        public Nullable<System.DateTime> DateModifiedUTC { get; set; }
        public bool CalculateAgeByYearOfBirth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClubLeague> ClubLeagues { get; set; }
        public virtual Sport Sport { get; set; }
        public virtual Organisation Organisation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventPoint> EventPoints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RankingEvent> RankingEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RankingLevel> RankingLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RankingParticipant> RankingParticipants { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamLeagueRankingLevel> TeamLeagueRankingLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tournament> Tournaments { get; set; }
    }
}
