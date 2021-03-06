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
    
    public partial class TournamentInvitation
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecieverId { get; set; }
        public Nullable<int> TournamentId { get; set; }
        public System.DateTime DateCreatedUTC { get; set; }
        public int Status { get; set; }
        public Nullable<int> TournamentClassId { get; set; }
        public Nullable<int> PartnerId { get; set; }
        public bool WasLookingForPartner { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Player Player1 { get; set; }
        public virtual Tournament Tournament { get; set; }
        public virtual TournamentEvent TournamentEvent { get; set; }
    }
}
