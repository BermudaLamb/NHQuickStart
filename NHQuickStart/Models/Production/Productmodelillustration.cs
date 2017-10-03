using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productmodelillustration
    {
        public Productmodelillustration() { }
		public virtual long Productmodelid { get; set; }	// NOT NULL
		public virtual Productmodel Productmodel { get; set; }
		public virtual long Illustrationid { get; set; }	// NOT NULL
		public virtual Illustration Illustration { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Productmodelillustration;
            if (t == null) return false;
            if (Illustrationid == t.Illustrationid
			&& Productmodelid == t.Productmodelid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Illustrationid.GetHashCode();
			hash = (hash * 397) ^ Productmodelid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
