using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productsubcategory
    {
        public Productsubcategory() { }
		public virtual long Productsubcategoryid { get; set; }	// NOT NULL
		public virtual long Productcategoryid { get; set; }	// NOT NULL
		public virtual Productcategory Productcategory { get; set; }
		public virtual string Name { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
