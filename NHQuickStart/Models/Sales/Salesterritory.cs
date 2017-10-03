using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesterritory
    {
        public Salesterritory() { }
		public virtual long Territoryid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Countryregioncode { get; set; }	// NOT NULL
		public virtual Person.Countryregion Countryregion { get; set; }
		public virtual string Group { get; set; }	// NOT NULL
		public virtual decimal Salesytd { get; set; }	// NOT NULL
		public virtual decimal Saleslastyear { get; set; }	// NOT NULL
		public virtual decimal Costytd { get; set; }	// NOT NULL
		public virtual decimal Costlastyear { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
