using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productinventory
    {
        public Productinventory() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual int Locationid { get; set; }	// NOT NULL
		public virtual Location Location { get; set; }
		public virtual string Shelf { get; set; }	// NOT NULL
		public virtual short Bin { get; set; }	// NOT NULL
		public virtual int Quantity { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productinventory;
            if (t == null) return false;
            if (Locationid == t.Locationid
			&& Productid == t.Productid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Locationid.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
