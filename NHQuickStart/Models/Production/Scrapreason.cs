using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Scrapreason
    {
        public Scrapreason() { }
		public virtual int Scrapreasonid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
