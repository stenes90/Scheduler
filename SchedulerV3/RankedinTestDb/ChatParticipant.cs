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
    
    public partial class ChatParticipant
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int PlayerId { get; set; }
        public System.DateTime DateAddedUTC { get; set; }
        public int NewMessages { get; set; }
    
        public virtual Chat Chat { get; set; }
        public virtual Player Player { get; set; }
    }
}
