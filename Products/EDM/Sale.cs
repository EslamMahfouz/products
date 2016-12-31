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
    
    public partial class Sale
    {
        public Sale()
        {
            this.SalesDetails = new HashSet<SalesDetail>();
        }
    
        public int SaleID { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public Nullable<double> SalePrice { get; set; }
        public Nullable<double> SaleDiscount { get; set; }
        public Nullable<double> SaleNetPrice { get; set; }
        public Nullable<double> SalePaid { get; set; }
        public Nullable<double> SaleCharge { get; set; }
        public int CustomerID { get; set; }
        public int SaleNumber { get; set; }
        public Nullable<double> SaleBuyPrice { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
