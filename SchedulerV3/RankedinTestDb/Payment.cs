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
    
    public partial class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Date { get; set; }
        public int ParticipantToJoinType { get; set; }
        public int ParticipantToJoinId { get; set; }
        public int EventType { get; set; }
        public int EventId { get; set; }
        public Nullable<int> PaymentState { get; set; }
        public string RankedinTransactionId { get; set; }
        public string PayPalTransationId { get; set; }
        public string ItemName { get; set; }
        public int CurrencyId { get; set; }
        public string RankedinPaymentRequestQuery { get; set; }
        public int PlayerId { get; set; }
    }
}
