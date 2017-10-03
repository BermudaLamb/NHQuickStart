using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
    public class Purchaseorderdetail
    {
        public Purchaseorderdetail() { }
		public virtual long Purchaseorderid { get; set; }	// NOT NULL
		public virtual Purchaseorderheader Purchaseorderheader { get; set; }
		public virtual long Purchaseorderdetailid { get; set; }	// NOT NULL
		public virtual DateTime Duedate { get; set; }	// NOT NULL
		public virtual int Orderqty { get; set; }	// NOT NULL
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Production.Product Product { get; set; }
		public virtual decimal Unitprice { get; set; }	// NOT NULL
		public virtual decimal Linetotal { get; set; }	// NOT NULL
		public virtual decimal Receivedqty { get; set; }	// NOT NULL
		public virtual decimal Rejectedqty { get; set; }	// NOT NULL
		public virtual decimal Stockedqty { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Purchaseorderdetail;
            if (t == null) return false;
            if (Purchaseorderdetailid == t.Purchaseorderdetailid
			&& Purchaseorderid == t.Purchaseorderid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Purchaseorderdetailid.GetHashCode();
			hash = (hash * 397) ^ Purchaseorderid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
