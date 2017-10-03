using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Shoppingcartitem
    {
        public Shoppingcartitem() { }
		public virtual long Shoppingcartitemid { get; set; }	// NOT NULL
		public virtual string Shoppingcartid { get; set; }	// NOT NULL
		public virtual long Quantity { get; set; }	// NOT NULL
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Production.Product Product { get; set; }
		public virtual DateTime Datecreated { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
