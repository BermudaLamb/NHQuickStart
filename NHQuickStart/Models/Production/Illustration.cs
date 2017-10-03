using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Illustration
    {
        public Illustration() { }
		public virtual long Illustrationid { get; set; }	// NOT NULL
		public virtual string Diagram { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
