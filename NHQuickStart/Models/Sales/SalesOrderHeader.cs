using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesorderheader
    {
        public Salesorderheader() { }
		public virtual long Salesorderid { get; set; }	// NOT NULL
		public virtual short Revisionnumber { get; set; }	// NOT NULL
		public virtual DateTime Orderdate { get; set; }	// NOT NULL
		public virtual DateTime Duedate { get; set; }	// NOT NULL
		public virtual DateTime? Shipdate { get; set; }
		public virtual short Status { get; set; }	// NOT NULL
		public virtual bool Onlineorderflag { get; set; }	// NOT NULL
		public virtual string Salesordernumber { get; set; }	// NOT NULL
		public virtual string Purchaseordernumber { get; set; }
		public virtual string Accountnumber { get; set; }
		public virtual long Customerid { get; set; }	// NOT NULL
		public virtual Customer Customer { get; set; }
		public virtual long? Salespersonid { get; set; }
		public virtual Salesperson Salesperson { get; set; }
		public virtual long? Territoryid { get; set; }
		public virtual Salesterritory Salesterritory { get; set; }
		public virtual long Billtoaddressid { get; set; }	// NOT NULL
		public virtual Person.Address BilltoAddress { get; set; }
		public virtual long Shiptoaddressid { get; set; }	// NOT NULL
		public virtual Person.Address ShiptoAddress { get; set; }
		public virtual long Shipmethodid { get; set; }	// NOT NULL
		public virtual Purchasing.Shipmethod Shipmethod { get; set; }
		public virtual long? Creditcardid { get; set; }
		public virtual Creditcard Creditcard { get; set; }
		public virtual string Creditcardapprovalcode { get; set; }
		public virtual long? Currencyrateid { get; set; }
		public virtual Currencyrate Currencyrate { get; set; }
		public virtual decimal Subtotal { get; set; }	// NOT NULL
		public virtual decimal Taxamt { get; set; }	// NOT NULL
		public virtual decimal Freight { get; set; }	// NOT NULL
		public virtual decimal Totaldue { get; set; }	// NOT NULL
		public virtual string Comment { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
