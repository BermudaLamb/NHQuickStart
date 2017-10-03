using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Workorder
    {
        public Workorder() { }
		public virtual long Workorderid { get; set; }	// NOT NULL
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual long Orderqty { get; set; }	// NOT NULL
		public virtual long Stockedqty { get; set; }	// NOT NULL
		public virtual int Scrappedqty { get; set; }	// NOT NULL
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime? Enddate { get; set; }
		public virtual DateTime Duedate { get; set; }	// NOT NULL
		public virtual int? Scrapreasonid { get; set; }
		public virtual Scrapreason Scrapreason { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
