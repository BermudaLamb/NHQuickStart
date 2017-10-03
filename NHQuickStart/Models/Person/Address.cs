using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Address
    {
        public Address() { }
		public virtual long Addressid { get; set; }	// NOT NULL
		public virtual string Addressline1 { get; set; }	// NOT NULL
		public virtual string Addressline2 { get; set; }
		public virtual string City { get; set; }	// NOT NULL
		public virtual long Stateprovinceid { get; set; }	// NOT NULL
		public virtual Stateprovince Stateprovince { get; set; }
		public virtual string Postalcode { get; set; }	// NOT NULL
		public virtual string Spatiallocation { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
