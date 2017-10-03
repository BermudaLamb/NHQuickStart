using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salespersonquotahistory
    {
        public Salespersonquotahistory() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Salesperson Salesperson { get; set; }
		public virtual DateTime Quotadate { get; set; }	// NOT NULL
		public virtual decimal Salesquota { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Salespersonquotahistory;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Quotadate == t.Quotadate) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Quotadate.GetHashCode();

            return hash;
        }
        #endregion
    }
}
