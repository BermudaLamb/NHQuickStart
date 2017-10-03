using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productdocument
    {
        public Productdocument() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Product Product { get; set; }
		public virtual string Documentnode { get; set; }	// NOT NULL
		public virtual Document Document { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productdocument;
            if (t == null) return false;
            if (Documentnode == t.Documentnode
			&& Productid == t.Productid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Documentnode.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
