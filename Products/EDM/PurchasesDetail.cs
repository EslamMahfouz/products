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
    
    public partial class PurchasesDetail
    {
        public int PurchaseID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> ProductQte { get; set; }
        public Nullable<double> ProductPrice { get; set; }
        public Nullable<double> ProductDiscount { get; set; }
        public Nullable<double> ProductNetPrice { get; set; }
        public Nullable<double> ProductBuy { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
