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
    
    public partial class ChatMessage
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string MessageText { get; set; }
        public System.DateTime DateCreatedUTC { get; set; }
        public int CreatorPlayerId { get; set; }
    
        public virtual Chat Chat { get; set; }
    }
}
