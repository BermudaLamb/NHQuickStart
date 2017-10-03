using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
    public class Purchaseorderheader
    {
        public Purchaseorderheader() { }
		public virtual long Purchaseorderid { get; set; }	// NOT NULL
		public virtual short Revisionnumber { get; set; }	// NOT NULL
		public virtual short Status { get; set; }	// NOT NULL
		public virtual long Employeeid { get; set; }	// NOT NULL
		public virtual HumanResources.Employee Employee { get; set; }
		public virtual long Vendorid { get; set; }	// NOT NULL
		public virtual Vendor Vendor { get; set; }
		public virtual long Shipmethodid { get; set; }	// NOT NULL
		public virtual Shipmethod Shipmethod { get; set; }
		public virtual DateTime Orderdate { get; set; }	// NOT NULL
		public virtual DateTime? Shipdate { get; set; }
		public virtual decimal Subtotal { get; set; }	// NOT NULL
		public virtual decimal Taxamt { get; set; }	// NOT NULL
		public virtual decimal Freight { get; set; }	// NOT NULL
		public virtual decimal Totaldue { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
