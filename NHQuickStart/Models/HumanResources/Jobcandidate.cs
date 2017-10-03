using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.HumanResources
{
    public class Jobcandidate
    {
        public Jobcandidate() { }
		public virtual long Jobcandidateid { get; set; }	// NOT NULL
		public virtual long? Businessentityid { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual string Resume { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
