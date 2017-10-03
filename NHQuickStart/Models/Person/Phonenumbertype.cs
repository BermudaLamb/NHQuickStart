using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Phonenumbertype
    {
        public Phonenumbertype() { }
		public virtual long Phonenumbertypeid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
