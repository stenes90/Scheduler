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
    
    public partial class OrganizationAdmin
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int OrganizationId { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Organisation Organisation { get; set; }
    }
}
