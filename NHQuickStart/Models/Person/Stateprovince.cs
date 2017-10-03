using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Stateprovince
    {
        public Stateprovince() { }
		public virtual long Stateprovinceid { get; set; }	// NOT NULL
		public virtual string Stateprovincecode { get; set; }	// NOT NULL
		public virtual string Countryregioncode { get; set; }	// NOT NULL
		public virtual Countryregion Countryregion { get; set; }
		public virtual bool Isonlystateprovinceflag { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual long Territoryid { get; set; }	// NOT NULL
		public virtual Sales.Salesterritory Salesterritory { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
