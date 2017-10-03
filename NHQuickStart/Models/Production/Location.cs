using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Location
    {
        public Location() { }
		public virtual int Locationid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual decimal Costrate { get; set; }	// NOT NULL
		public virtual decimal Availability { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
