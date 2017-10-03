using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Businessentity
    {
        public Businessentity() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
