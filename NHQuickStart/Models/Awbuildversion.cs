using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models
{
    public class Awbuildversion
    {
        public Awbuildversion() { }
		public virtual short Systeminformationid { get; set; }	// NOT NULL
		public virtual string Database-Version { get; set; }	// NOT NULL
		public virtual DateTime Versiondate { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
