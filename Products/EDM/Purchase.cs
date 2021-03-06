//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Products.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public Purchase()
        {
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
            this.PurchasePayments = new HashSet<PurchasePayment>();
        }
    
        public int Id { get; set; }
        public double SupplierId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int Number { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> TotalAfterDiscount { get; set; }
    
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<PurchasePayment> PurchasePayments { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
