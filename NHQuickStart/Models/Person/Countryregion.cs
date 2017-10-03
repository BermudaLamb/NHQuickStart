using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Countryregion
    {
        public Countryregion() { }
		public virtual string Countryregioncode { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
