using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
    public class Shipmethod
    {
        public Shipmethod() { }
		public virtual long Shipmethodid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual decimal Shipbase { get; set; }	// NOT NULL
		public virtual decimal Shiprate { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
