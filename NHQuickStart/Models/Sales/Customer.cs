using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Customer
    {
        public Customer() { }
		public virtual long Customerid { get; set; }	// NOT NULL
		public virtual long? Personid { get; set; }
		public virtual Person.Person Person { get; set; }
		public virtual long? Storeid { get; set; }
		public virtual Store Store { get; set; }
		public virtual long? Territoryid { get; set; }
		public virtual Salesterritory Salesterritory { get; set; }
		public virtual string Accountnumber { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
