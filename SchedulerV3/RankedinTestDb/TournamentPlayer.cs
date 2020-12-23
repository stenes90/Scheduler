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
    
    public partial class TournamentPlayer
    {
        public int tp_id { get; set; }
        public int tp_event { get; set; }
        public int LowSeed { get; set; }
        public bool tp_feePaid { get; set; }
        public bool tp_accepted { get; set; }
        public int tp_postorder { get; set; }
        public int HighSeed { get; set; }
        public int SeedOrder { get; set; }
        public int RankingPosition { get; set; }
        public int InitialOrder { get; set; }
        public Nullable<int> StartDrawStage { get; set; }
        public int ParticipantId { get; set; }
    
        public virtual Participant Participant { get; set; }
        public virtual TournamentEvent TournamentEvent { get; set; }
    }
}