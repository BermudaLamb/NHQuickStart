using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Specialoffer
    {
        public Specialoffer() { }
		public virtual long Specialofferid { get; set; }	// NOT NULL
		public virtual string Description { get; set; }	// NOT NULL
		public virtual decimal Discountpct { get; set; }	// NOT NULL
		public virtual string Type { get; set; }	// NOT NULL
		public virtual string Category { get; set; }	// NOT NULL
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime Enddate { get; set; }	// NOT NULL
		public virtual long Minqty { get; set; }	// NOT NULL
		public virtual long? Maxqty { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
