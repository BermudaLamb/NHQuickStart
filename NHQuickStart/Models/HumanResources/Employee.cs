using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Employee
    {
        public Employee() { }
		public virtual long Businessentityid { get; set; }	// NOT NULL
		public virtual Person.Person Person { get; set; }
		public virtual string Nationalidnumber { get; set; }	// NOT NULL
		public virtual string Loginid { get; set; }	// NOT NULL
		public virtual string Organizationnode { get; set; }
		public virtual int? Organizationlevel { get; set; }
		public virtual string Jobtitle { get; set; }	// NOT NULL
		public virtual DateTime Birthdate { get; set; }	// NOT NULL
		public virtual string Maritalstatus { get; set; }	// NOT NULL
		public virtual string Gender { get; set; }	// NOT NULL
		public virtual DateTime Hiredate { get; set; }	// NOT NULL
		public virtual bool Salariedflag { get; set; }	// NOT NULL
		public virtual int Vacationhours { get; set; }	// NOT NULL
		public virtual int Sickleavehours { get; set; }	// NOT NULL
		public virtual bool Currentflag { get; set; }	// NOT NULL
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
