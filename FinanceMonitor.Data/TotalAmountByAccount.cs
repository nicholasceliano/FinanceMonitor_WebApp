//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceMonitor.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TotalAmountByAccount
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
