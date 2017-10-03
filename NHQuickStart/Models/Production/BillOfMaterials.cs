using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Billofmaterials
    {
        public Billofmaterials() { }
		public virtual long Billofmaterialsid { get; set; }	// NOT NULL
		public virtual long? Productassemblyid { get; set; }
		public virtual Product Product { get; set; }
		public virtual Product Component { get; set; }
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime? Enddate { get; set; }
		public virtual string Unitmeasurecode { get; set; }	// NOT NULL
		public virtual Unitmeasure Unitmeasure { get; set; }
		public virtual int Bomlevel { get; set; }	// NOT NULL
		public virtual decimal Perassemblyqty { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
