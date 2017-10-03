using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productcategory
    {
        public Productcategory() { }
		public virtual long Productcategoryid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
