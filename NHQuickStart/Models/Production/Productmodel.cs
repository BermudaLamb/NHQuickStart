using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productmodel
    {
        public Productmodel() { }
		public virtual long Productmodelid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Catalogdescription { get; set; }
		public virtual string Instructions { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
