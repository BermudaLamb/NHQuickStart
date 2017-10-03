using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesperson
    {
        public Salesperson() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual HumanResources.Employee Employee { get; set; }
		public virtual long? Territoryid { get; set; }
		public virtual Salesterritory Salesterritory { get; set; }
		public virtual decimal? Salesquota { get; set; }
		public virtual decimal Bonus { get; set; }	// NOT NULL
		public virtual decimal Commissionpct { get; set; }	// NOT NULL
		public virtual decimal Salesytd { get; set; }	// NOT NULL
		public virtual decimal Saleslastyear { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
