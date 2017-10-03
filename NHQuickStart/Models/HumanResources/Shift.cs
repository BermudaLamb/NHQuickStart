using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Shift
    {
        public Shift() { }
		public virtual short Shiftid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual DateTime Starttime { get; set; }	// NOT NULL
		public virtual DateTime Endtime { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
