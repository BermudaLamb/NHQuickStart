using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Employeedepartmenthistory
    {
        public Employeedepartmenthistory() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Employee Employee { get; set; }
		public virtual int Departmentid { get; set; }	// NOT NULL
		public virtual Department Department { get; set; }
		public virtual short Shiftid { get; set; }	// NOT NULL
		public virtual Shift Shift { get; set; }
		public virtual DateTime Startdate { get; set; }	// NOT NULL
		public virtual DateTime? Enddate { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Employeedepartmenthistory;
            if (t == null) return false;
            if (Businessentityid == t.Businessentityid
			&& Departmentid == t.Departmentid
			&& Shiftid == t.Shiftid
			&& Startdate == t.Startdate) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Businessentityid.GetHashCode();
			hash = (hash * 397) ^ Departmentid.GetHashCode();
			hash = (hash * 397) ^ Shiftid.GetHashCode();
			hash = (hash * 397) ^ Startdate.GetHashCode();

            return hash;
        }
        #endregion
    }
}
