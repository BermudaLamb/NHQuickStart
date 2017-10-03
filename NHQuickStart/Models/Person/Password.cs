using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Password
    {
        public Password() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person Person { get; set; }
		public virtual string Passwordhash { get; set; }	// NOT NULL
		public virtual string Passwordsalt { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
