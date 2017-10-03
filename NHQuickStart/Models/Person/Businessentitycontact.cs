using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Businessentitycontact
    {
        public Businessentitycontact() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Businessentity Businessentity { get; set; }
		public virtual long Personid { get; set; }	// NOT NULL
		public virtual Person Person { get; set; }
		public virtual long Contacttypeid { get; set; }	// NOT NULL
		public virtual Contacttype Contacttype { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Businessentitycontact;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Contacttypeid == t.Contacttypeid
			&& Personid == t.Personid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Contacttypeid.GetHashCode();
			hash = (hash * 397) ^ Personid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
