using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Personcreditcard
    {
        public Personcreditcard() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person.Person Person { get; set; }
		public virtual long Creditcardid { get; set; }	// NOT NULL
		public virtual Creditcard Creditcard { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Personcreditcard;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Creditcardid == t.Creditcardid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Creditcardid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
