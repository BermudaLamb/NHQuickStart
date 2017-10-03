using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesterritoryhistory
    {
        public Salesterritoryhistory() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Salesperson Salesperson { get; set; }
		public virtual long Territoryid { get; set; }	// NOT NULL
		public virtual Salesterritory Salesterritory { get; set; }
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime? Enddate { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Salesterritoryhistory;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Startdate == t.Startdate
			&& Territoryid == t.Territoryid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();
			hash = (hash * 397) ^ Territoryid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
