using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesorderheadersalesreason
    {
        public Salesorderheadersalesreason() { }
		public virtual long Salesorderid { get; set; }	// NOT NULL
		public virtual Salesorderheader Salesorderheader { get; set; }
		public virtual long Salesreasonid { get; set; }	// NOT NULL
		public virtual Salesreason Salesreason { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Salesorderheadersalesreason;
            if (t == null) return false;
            if (Salesorderid == t.Salesorderid
			&& Salesreasonid == t.Salesreasonid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Salesorderid.GetHashCode();
			hash = (hash * 397) ^ Salesreasonid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
