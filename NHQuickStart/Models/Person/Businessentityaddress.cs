using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Businessentityaddress
    {
        public Businessentityaddress() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Businessentity Businessentity { get; set; }
		public virtual long Addressid { get; set; }	// NOT NULL
		public virtual Address Address { get; set; }
		public virtual long Addresstypeid { get; set; }	// NOT NULL
		public virtual Addresstype Addresstype { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Businessentityaddress;
            if (t == null) return false;
            if (Addressid == t.Addressid
			&& Addresstypeid == t.Addresstypeid
			&& Businessentityid == t.Businessentityid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Addressid.GetHashCode();
			hash = (hash * 397) ^ Addresstypeid.GetHashCode();
			hash = (hash * 397) ^ Businessentityid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
