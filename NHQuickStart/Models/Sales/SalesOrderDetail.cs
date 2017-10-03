using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Salesorderdetail
    {
        public Salesorderdetail() { }
		public virtual long Salesorderid { get; set; }	// NOT NULL
		public virtual Salesorderheader Salesorderheader { get; set; }
		public virtual long Salesorderdetailid { get; set; }	// NOT NULL
		public virtual string Carriertrackingnumber { get; set; }
		public virtual int Orderqty { get; set; }	// NOT NULL
		public virtual Specialofferproduct Specialofferproduct { get; set; }
		public virtual decimal Unitprice { get; set; }	// NOT NULL
		public virtual decimal Unitpricediscount { get; set; }	// NOT NULL
		public virtual double Linetotal { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Salesorderdetail;
            if (t == null) return false;
            if (Salesorderdetailid == t.Salesorderdetailid
			&& Salesorderid == t.Salesorderid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Salesorderdetailid.GetHashCode();
			hash = (hash * 397) ^ Salesorderid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
