using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Department
    {
        public Department() { }
		public virtual int Departmentid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Groupname { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
