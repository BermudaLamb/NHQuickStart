using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productcosthistory
    {
        public Productcosthistory() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime? Enddate { get; set; }
		public virtual decimal Standardcost { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productcosthistory;
            if (t == null) return false;
            if (Productid == t.Productid
			&& Startdate == t.Startdate) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();

            return hash;
        }
        #endregion
    }
}
