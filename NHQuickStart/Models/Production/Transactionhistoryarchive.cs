using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Transactionhistoryarchive
    {
        public Transactionhistoryarchive() { }
		public virtual long Transactionid { get; set; }	// NOT NULL
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual long Referenceorderid { get; set; }	// NOT NULL
		public virtual long Referenceorderlineid { get; set; }	// NOT NULL
		public virtual DateTime Transactiondate { get; set; }	// NOT NULL
		public virtual string Transactiontype { get; set; }	// NOT NULL
		public virtual long Quantity { get; set; }	// NOT NULL
		public virtual decimal Actualcost { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
