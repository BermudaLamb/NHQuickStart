using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Emailaddress
    {
        public Emailaddress() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person Person { get; set; }
		public virtual long Emailaddressid { get; set; }	// NOT NULL
		public virtual string Emailaddressval { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Emailaddress;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Emailaddressid == t.Emailaddressid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Emailaddressid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
