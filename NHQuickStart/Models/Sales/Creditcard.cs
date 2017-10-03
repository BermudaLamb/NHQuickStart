using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Creditcard
    {
        public Creditcard() { }
		public virtual long Creditcardid { get; set; }	// NOT NULL
		public virtual string Cardtype { get; set; }	// NOT NULL
		public virtual string Cardnumber { get; set; }	// NOT NULL
		public virtual short Expmonth { get; set; }	// NOT NULL
		public virtual int Expyear { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
