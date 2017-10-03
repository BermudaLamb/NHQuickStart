using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Employeepayhistory
    {
        public Employeepayhistory() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Employee Employee { get; set; }
		public virtual DateTime Ratechangedate { get; set; }	// NOT NULL
		public virtual decimal Rate { get; set; }	// NOT NULL
		public virtual short Payfrequency { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Employeepayhistory;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Ratechangedate == t.Ratechangedate) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Ratechangedate.GetHashCode();

            return hash;
        }
        #endregion
    }
}
