using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productproductphoto
    {
        public Productproductphoto() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual long Productphotoid { get; set; }	// NOT NULL
		public virtual Productphoto Productphoto { get; set; }
		public virtual bool Primary { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productproductphoto;
            if (t == null) return false;
            if (Productid == t.Productid
			&& Productphotoid == t.Productphotoid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Productphotoid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
