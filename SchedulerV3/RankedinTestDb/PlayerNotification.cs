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
    
    public partial class PlayerNotification
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public System.DateTime Date { get; set; }
        public string Text { get; set; }
        public string RequestedAction { get; set; }
        public bool IsNew { get; set; }
        public bool IsSeen { get; set; }
        public int NotificationType { get; set; }
        public int ActionType { get; set; }
        public Nullable<int> EventId { get; set; }
    
        public virtual Player Player { get; set; }
    }
}