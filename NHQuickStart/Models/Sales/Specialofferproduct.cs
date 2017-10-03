using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Specialofferproduct
    {
        public Specialofferproduct() { }
		public virtual long Specialofferid { get; set; }	// NOT NULL
		public virtual Specialoffer Specialoffer { get; set; }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual Production.Product Product { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
            if (obj == null) return false;
            var t = obj as Specialofferproduct;
            if (t == null) return false;
            if (Productid == t.Productid
			&& Specialofferid == t.Specialofferid) 
                return true;

            return false;
        }
        public override int GetHashCode() {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ Productid.GetHashCode();
			hash = (hash * 397) ^ Specialofferid.GetHashCode();

            return hash;
        }
        #endregion
    }
}
