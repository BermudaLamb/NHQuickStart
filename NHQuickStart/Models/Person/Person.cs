using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Person
{
    public class Person
    {
        public Person() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Businessentity Businessentity { get; set; }
		public virtual string Persontype { get; set; }	// NOT NULL
		public virtual bool Namestyle { get; set; }	// NOT NULL
		public virtual string Title { get; set; }
		public virtual string Firstname { get; set; }	// NOT NULL
		public virtual string Middlename { get; set; }
		public virtual string Lastname { get; set; }	// NOT NULL
		public virtual string Suffix { get; set; }
		public virtual long Emailpromotion { get; set; }	// NOT NULL
		public virtual string Additionalcontactinfo { get; set; }
		public virtual string Demographics { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
