using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models
{
    public class Errorlog
    {
        public Errorlog() { }
		public virtual long Errorlogid { get; set; }	// NOT NULL
		public virtual DateTime Errortime { get; set; }	// NOT NULL
		public virtual string Username { get; set; }	// NOT NULL
		public virtual long Errornumber { get; set; }	// NOT NULL
		public virtual long? Errorseverity { get; set; }
		public virtual long? Errorstate { get; set; }
		public virtual string Errorprocedure { get; set; }
		public virtual long? Errorline { get; set; }
		public virtual string Errormessage { get; set; }	// NOT NULL
    }
}
