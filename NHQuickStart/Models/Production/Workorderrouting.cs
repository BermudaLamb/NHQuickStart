using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Workorderrouting
    {
        public Workorderrouting() { }
		public virtual long Workorderid { get; set; }	// NOT NULL
		public virtual Workorder Workorder { get; set; }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual int Operationsequence { get; set; }	// NOT NULL
		public virtual int Locationid { get; set; }	// NOT NULL
		public virtual Location Location { get; set; }
		public virtual DateTime Scheduledstartdate { get; set; }	// NOT NULL
		public virtual DateTime Scheduledenddate { get; set; }	// NOT NULL
		public virtual DateTime? Actualstartdate { get; set; }
		public virtual DateTime? Actualenddate { get; set; }
		public virtual decimal? Actualresourcehrs { get; set; }
		public virtual decimal Plannedcost { get; set; }	// NOT NULL
		public virtual decimal? Actualcost { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Workorderrouting;
            if (t == null) return false;
            if (Operationsequence == t.Operationsequence
			&& Productid == t.Productid
			&& Workorderid == t.Workorderid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Operationsequence.GetHashCode();
			hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Workorderid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
