using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Unitmeasure
    {
        public Unitmeasure() { }
		public virtual string Unitmeasurecode { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
