using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Personphone
    {
        public Personphone() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person Person { get; set; }
		public virtual string Phonenumber { get; set; }	// NOT NULL
		public virtual long Phonenumbertypeid { get; set; }	// NOT NULL
		public virtual Phonenumbertype Phonenumbertype { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Personphone;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Phonenumber == t.Phonenumber
			&& Phonenumbertypeid == t.Phonenumbertypeid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Phonenumber.GetHashCode();
			hash = (hash * 397) ^ Phonenumbertypeid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
