using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
    public class Productvendor
    {
        public Productvendor() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Production.Product Product { get; set; }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Vendor Vendor { get; set; }
		public virtual long Averageleadtime { get; set; }	// NOT NULL
		public virtual decimal Standardprice { get; set; }	// NOT NULL
		public virtual decimal? Lastreceiptcost { get; set; }
		public virtual DateTime? Lastreceiptdate { get; set; }
		public virtual long Minorderqty { get; set; }	// NOT NULL
		public virtual long Maxorderqty { get; set; }	// NOT NULL
		public virtual long? Onorderqty { get; set; }
		public virtual string Unitmeasurecode { get; set; }	// NOT NULL
		public virtual Production.Unitmeasure Unitmeasure { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productvendor;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Productid == t.Productid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
