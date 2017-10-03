using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesreason
    {
        public Salesreason() { }
		public virtual long Salesreasonid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Reasontype { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
