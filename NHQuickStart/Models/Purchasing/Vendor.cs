using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
    public class Vendor
    {
        public Vendor() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person.Businessentity Businessentity { get; set; }
		public virtual string Accountnumber { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual short Creditrating { get; set; }	// NOT NULL
		public virtual bool Preferredvendorstatus { get; set; }	// NOT NULL
		public virtual bool Activeflag { get; set; }	// NOT NULL
		public virtual string Purchasingwebserviceurl { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
