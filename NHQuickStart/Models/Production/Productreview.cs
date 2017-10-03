using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productreview
    {
        public Productreview() { }
		public virtual long Productreviewid { get; set; }	// NOT NULL
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual string Reviewername { get; set; }	// NOT NULL
		public virtual DateTime Reviewdate { get; set; }	// NOT NULL
		public virtual string Emailaddress { get; set; }	// NOT NULL
		public virtual long Rating { get; set; }	// NOT NULL
		public virtual string Comments { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
