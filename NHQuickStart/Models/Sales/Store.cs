using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Store
    {
        public Store() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person.Businessentity Businessentity { get; set; }
		public virtual string Name { get; set; }	// NOT NULL
		public virtual long? Salespersonid { get; set; }
		public virtual Salesperson Salesperson { get; set; }
		public virtual string Demographics { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
