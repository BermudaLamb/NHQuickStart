using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productdescription
    {
        public Productdescription() { }
		public virtual long Productdescriptionid { get; set; }	// NOT NULL
		public virtual string Description { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
