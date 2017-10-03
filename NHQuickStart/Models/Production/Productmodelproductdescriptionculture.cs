using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productmodelproductdescriptionculture
    {
        public Productmodelproductdescriptionculture() { }
		public virtual long Productmodelid { get; set; }	// NOT NULL
		public virtual Productmodel Productmodel { get; set; }
		public virtual long Productdescriptionid { get; set; }	// NOT NULL
		public virtual Productdescription Productdescription { get; set; }
		public virtual string Cultureid { get; set; }	// NOT NULL
		public virtual Culture Culture { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productmodelproductdescriptionculture;
            if (t == null) return false;
            if (Cultureid == t.Cultureid
			&& Productdescriptionid == t.Productdescriptionid
			&& Productmodelid == t.Productmodelid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Cultureid.GetHashCode();
			hash = (hash * 397) ^ Productdescriptionid.GetHashCode();
			hash = (hash * 397) ^ Productmodelid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
