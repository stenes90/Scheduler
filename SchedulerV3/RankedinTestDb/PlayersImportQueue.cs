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
    
    public partial class PlayersImportQueue
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public Nullable<int> Gender { get; set; }
        public string CountryCode { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<decimal> InitialRanking { get; set; }
        public int ImportStatus { get; set; }
        public Nullable<System.DateTime> DateImported { get; set; }
        public Nullable<int> PlayerId { get; set; }
        public Nullable<int> HomeClubId { get; set; }
    }
}
