using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salestaxrate
    {
        public Salestaxrate() { }
		public virtual long Salestaxrateid { get; set; }	// NOT NULL
		public virtual long Stateprovinceid { get; set; }	// NOT NULL
		public virtual Person.Stateprovince Stateprovince { get; set; }
		public virtual short Taxtype { get; set; }	// NOT NULL
		public virtual decimal Taxrate { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
